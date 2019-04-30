using UnityEngine;
using Unity.Collections;
using Unity.Networking.Transport;

using NetworkConnection = Unity.Networking.Transport.NetworkConnection;
using UdpCNetworkDriver = Unity.Networking.Transport.UdpNetworkDriver;

public class Client : MonoBehaviour {

    public UdpCNetworkDriver Driver;
    public NetworkConnection Connection;

    private void Start() {
        Driver = new UdpCNetworkDriver(new INetworkParameter[0]);
        Connection = default;

        NetworkEndPoint endpoint = NetworkEndPoint.Parse("127.0.0.1", 9000);
        Connection = Driver.Connect(endpoint);
    }

    public void OnDestroy() {
        Driver.Dispose();
    }

    private void Update() {
        Driver.ScheduleUpdate().Complete();

        if (!Connection.IsCreated) {
            return;
        }

        NetworkEvent.Type cmd;

        while ((cmd = Connection.PopEvent(Driver, out DataStreamReader stream)) != NetworkEvent.Type.Empty) {
            if (cmd == NetworkEvent.Type.Connect) {
                Debug.Log("We are now connected to the server");

                //using (DataStreamWriter writer = new DataStreamWriter(4, Allocator.Temp)) {
                //    Connection.Send(Driver, writer);
                //}
            }
            else if (cmd == NetworkEvent.Type.Data) {
                DataStreamReader.Context context = default;
                float x = stream.ReadFloat(ref context);
                float y = stream.ReadFloat(ref context);
                float z = stream.ReadFloat(ref context);
                Vector3 point = new Vector3(x, y, z);
                if (Physics.Raycast(Camera.main.ScreenPointToRay(point), out RaycastHit hit, 1 << LayerMask.NameToLayer("Cell"))) {
                    Cell cell = hit.collider.GetComponent<Cell>();
                    if (cell == null) return;
                    cell.Reveal(Color.blue);
                }
            }
            else if (cmd == NetworkEvent.Type.Disconnect) {
                Debug.Log("Client got disconnected from server");
                Connection = default;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            using (DataStreamWriter writer = new DataStreamWriter(12, Allocator.Temp)) {
                writer.Write(Input.mousePosition.x);
                writer.Write(Input.mousePosition.y);
                writer.Write(Input.mousePosition.z);
                Driver.Send(NetworkPipeline.Null, Connection, writer);
            }
        }
    }
}