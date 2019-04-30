using UnityEngine;

public class Cell : MonoBehaviour {

    [SerializeField] private Material flagMaterial = null;

    private MeshRenderer meshRenderer = null;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Reveal(Color color) {
        //Update neighbours
        meshRenderer.material.color = color;
    }

    public void Flag() {
        meshRenderer.material = flagMaterial;
    }
}
