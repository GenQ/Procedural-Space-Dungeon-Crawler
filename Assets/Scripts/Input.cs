using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Input : MonoBehaviour {
    private Movement movement;

    private void Start() {
        movement = GetComponent<Movement>();
    }

    private void Update() {
        float x = UnityEngine.Input.GetAxis("Horizontal");
        float y = UnityEngine.Input.GetAxis("Vertical");

        movement.Move(x, y);
    }
}
