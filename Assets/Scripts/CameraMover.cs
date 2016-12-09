using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            transform.position = transform.position + Vector3.forward;
        } else if (Input.GetKeyDown(KeyCode.A)) {
            transform.position = transform.position + Vector3.left;
        } else if (Input.GetKeyDown(KeyCode.S)) {
            transform.position = transform.position + Vector3.back;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            transform.position = transform.position + Vector3.right;
        }
    }
}
