using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInputController_2 : MonoBehaviour {

    public MyInputAction myInput;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ButtonDown()) {
            myInput.buttonAction = MyInputAction.ButtonAction.PressedDown;
        } else if (ButtonUp()) {
            myInput.buttonAction = MyInputAction.ButtonAction.ReleasedUp;
        } else {
            myInput.buttonAction = MyInputAction.ButtonAction.None;
        }
    }

    public bool ButtonDown() {
        return Input.GetButtonDown("Fire1");
    }

    public bool ButtonUp() {
        return Input.GetButtonUp("Fire1");
    }
}
