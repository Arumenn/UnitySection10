using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool recording = true;
    public bool paused = false;

    private float initialFixedDeltaTime;

    private void Start() {
        initialFixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update () {
        recording = !CrossPlatformInputManager.GetButton("Fire1");

        if (CrossPlatformInputManager.GetButtonDown("Submit")) {
            TogglePauseGame();
        }
	}

    void TogglePauseGame() {
        if (paused) {
            ResumeGame();
        } else{
            PauseGame();
        }
    }

    void PauseGame() {
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;
        paused = true;
    }

    void ResumeGame() {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = initialFixedDeltaTime;
        paused = false;
    }
}