using UnityEngine;

using Unity.Networking.Transport;
using Unity.Collections;
using UnityEngine.Assertions;

using NetworkConnection = Unity.Networking.Transport.NetworkConnection;
using UdpCNetworkDriver = Unity.Networking.Transport.UdpNetworkDriver;
using System.Collections;

public class Server : MonoBehaviour {
    public UdpCNetworkDriver Driver;
    private NativeList<NetworkConnection> Connections;

    private void Start() {
        Driver = new UdpCNetworkDriver(new INetworkParameter[0]);
        if (Driver.Bind(NetworkEndPoint.Parse("0.0.0.0", 9000)) != 0) {
            Debug.Log("Failed to bind to port 9000");
        }
        else Driver.Listen();

        Connections = new NativeList<NetworkConnection>(16, Allocator.Persistent);
    }

    public void OnDestroy() {
        Driver.Dispose();
        Connections.Dispose();
    }

    private void Update() {
        Driver.ScheduleUpdate().Complete();

        for (int i = 0; i < Connections.Length; i++) {
            if (!Connections[i].IsCreated) {
                Connections.RemoveAtSwapBack(i);
                --i;
            }
        }

        NetworkConnection c;
        while ((c = Driver.Accept()) != default) {
            Connections.Add(c);
            Debug.Log("Accepted a connection");
        }

        float x = 0, y = 0, z = 0;

        for (int i = 0; i < Connections.Length; i++) {
            if (!Connections[i].IsCreated) Assert.IsTrue(true);
            NetworkEvent.Type cmd;

            while ((cmd = Driver.PopEventForConnection(Connections[i], out DataStreamReader stream)) != NetworkEvent.Type.Empty) {
                if (cmd == NetworkEvent.Type.Data) {
                    DataStreamReader.Context context = default;
                    x = stream.ReadFloat(ref context);
                    y = stream.ReadFloat(ref context);
                    z = stream.ReadFloat(ref context);
                    Vector3 point = new Vector3(x, y, z);
                    if (Physics.Raycast(Camera.main.ScreenPointToRay(point), out RaycastHit hit, 1 << LayerMask.NameToLayer("Cell"))) {
                        Cell cell = hit.collider.GetComponent<Cell>();
                        if (cell == null) return;
                        cell.Reveal(Color.blue);
                    }
                }
                else if (cmd == NetworkEvent.Type.Disconnect) {
                    Debug.Log("Client disconnected from server");
                    Connections[i] = default;
                }
            }
        }

        using (var writer = new DataStreamWriter(12, Allocator.Temp)) {
            writer.Write(x);
            writer.Write(y);
            writer.Write(z);
            for (int i = 0; i < Connections.Length; ++i) {
                Connections[i].Send(Driver, writer);
            }
        }
    }
}