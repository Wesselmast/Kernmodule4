using UnityEngine;

public class ShapeGenerator : MonoBehaviour {
    [SerializeField] private GameObject prefab = null;

    private void Start() {
        for (int x = -1; x <= 1; x++) {
            for (int y = -1; y <= 1; y++) {
                for (int z = -1; z <= 1; z++) {
                    Instantiate(prefab, new Vector3(x, y, z), transform.rotation, transform);
                }
            }
        }
    }
}
