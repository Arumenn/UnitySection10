using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform ballToFollow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //follows the ball
        Vector3 position = transform.position;
        position.z = ballToFollow.transform.position.z;
        transform.position = position;
	}
}
