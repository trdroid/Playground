﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController_3 : MonoBehaviour {
    public GameObject balloonPrefab;
    public float floatStrength = 20f;
    public float growRate = 1.5f;    

    private GameObject balloon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (balloon != null) {
            GrowBalloon();
        }
	}

    public void NewBalloon() {
        balloon = Instantiate(balloonPrefab);
    }

    public void ReleaseBalloon() {
        balloon.GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
        balloon = null;
    }

    private void GrowBalloon() {
        balloon.transform.localScale += balloon.transform.localScale * growRate * Time.deltaTime;
    }
}
