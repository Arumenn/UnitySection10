using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

    private Transform ballToFollow;

	// Use this for initialization
	void Start () {
        ballToFollow = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void LateUpdate () {
        //follows the ball
        /*Vector3 position = transform.position;
        position.z = ballToFollow.transform.position.z;
        transform.position = position;*/
        transform.LookAt(ballToFollow);
	}
}
