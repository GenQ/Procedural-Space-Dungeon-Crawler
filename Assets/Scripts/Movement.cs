using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] private float movementSpeed;


    public void Move(float x, float y) {
        Vector2 translation =  new Vector2(x, y) * movementSpeed * Time.deltaTime;
        transform.Translate(translation);
    }

    public void Look(Vector2 dir) {
        transform.rotation.SetLookRotation(dir);
    }
}
