using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

    private const int bufferFrames = 200;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
    private Rigidbody rigidBody;
    private GameManager gm;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gm.recording) {
            Record();
        } else {
            PlayBack();
        }
	}

    void PlayBack() {
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        transform.position = keyFrames[frame].position;
        transform.localRotation = keyFrames[frame].rotation;
    }

    void Record() {
        rigidBody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        keyFrames[frame] = new MyKeyFrame(Time.time, transform.position, transform.rotation);
    }
}

public class MyKeyFrame {
    public float frameTime;
    public Vector3 position;
    public Quaternion rotation;

    public MyKeyFrame(float time, Vector3 pos, Quaternion rot) {
        frameTime = time;
        position = pos;
        rot = rotation;
    }
}
