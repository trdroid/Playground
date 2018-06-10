using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ButtonTest();
	}

    private void ButtonTest() {
        string msg = null;

        if (Input.GetButtonDown("Fire1")) {
            msg = "Fire1 down";
        }

        if (Input.GetButtonUp("Fire1")) {
            msg = "Fire 1 up";
        }

        if (msg != null) {
            Debug.Log("Input: " + msg);
        }
    }

    public bool ButtonDown() {
        return Input.GetButtonDown("Fire1");
    }

    public bool ButtonUp() {
        return Input.GetButtonUp("Fire1");
    }
}
