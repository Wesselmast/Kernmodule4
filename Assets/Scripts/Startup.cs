using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startup : MonoBehaviour {
    public Object serverPrefab, client1Prefab, client2Prefab;
    public InputField input;
    public static System.Net.IPAddress address;

    public void Server() {
        //create server prefab
        DontDestroyOnLoad(Instantiate(serverPrefab) as GameObject);
        //create local client prefab
        DontDestroyOnLoad(Instantiate(client1Prefab) as GameObject);

        address = System.Net.IPAddress.Loopback;

        LoadScene();
    }

    public void Client() {
        //create remote client prefab
        DontDestroyOnLoad(Instantiate(client2Prefab) as GameObject);

        if (string.IsNullOrEmpty(input.text)) {
            address = System.Net.IPAddress.Loopback;
            LoadScene();
            return;
        }

        if (System.Net.IPAddress.TryParse(input.text, out address)) {
            LoadScene();
        }
        else {
            Debug.LogError("Invalid Server IP");
        }
    }

    private void LoadScene() {
        SceneManager.LoadScene("Game");
    }
}
