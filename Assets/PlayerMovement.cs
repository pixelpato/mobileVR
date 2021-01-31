using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed;
    private Camera cam;
    private Vector3 lookDir;


    private void Start () {
        // fetch the Rigidbody component you attach from your GameObject
        rigidbody = GetComponent<Rigidbody>();
        // fetch the player ain camera
        cam = GetComponentInChildren<Camera>();
        // set the speed of the GameObject
        speed = 2.0f;
        lookDir = cam.transform.eulerAngles;
    }

    private void Update () {
        if(Input.GetKey(KeyCode.W)) {
            //lookDir.z = cam.transform.rotation.z;
            //rigidbody.velocity = lookDir * speed;
            rigidbody.velocity = cam.transform.forward * speed;
        }

        if(Input.GetButton("Fire1"))
            rigidbody.velocity = cam.transform.forward * speed;

        if (Google.XR.Cardboard.Api.IsTriggerPressed) {
            //rigidbody.velocity = cam.transform.forward * speed;
        }
    }
}
