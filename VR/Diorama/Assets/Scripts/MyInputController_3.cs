using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyInputController_3 : MonoBehaviour {
    public UnityEvent ButtonDownEvent;
    public UnityEvent ButtonUpEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ButtonDown()) {
            ButtonDownEvent.Invoke();
        } else if (ButtonUp()) {
            ButtonUpEvent.Invoke();
        }
	}

    public bool ButtonDown() {
        return Input.GetButtonDown("Fire1");
    }

    public bool ButtonUp() {
        return Input.GetButtonUp("Fire1");
    }
}
