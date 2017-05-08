using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SelfieStick : MonoBehaviour {

    public float panSpeed = 2f;

    private GameObject ball;
    private Vector3 armRotation;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindGameObjectWithTag("Player");
        armRotation = transform.rotation.eulerAngles;

    }
	
	// Update is called once per frame
	void Update () {
        armRotation.y += CrossPlatformInputManager.GetAxis("RHoriz") * panSpeed;
        armRotation.x += CrossPlatformInputManager.GetAxis("RVert") * panSpeed;

        transform.position = ball.transform.position;
        transform.rotation = Quaternion.Euler(armRotation);
    }
}