using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController_2 : MonoBehaviour {
    public MyInputAction myInput;
    public GameObject balloonPrefab;
    private GameObject balloon;

    public float floatStrength = 20f;

    public float growRate = 1.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myInput.buttonAction == MyInputAction.ButtonAction.PressedDown && balloon == null) {
            Debug.Log("Creating a Balloon");
            NewBalloon();
        } else if (myInput.buttonAction == MyInputAction.ButtonAction.ReleasedUp && balloon != null) {
            Debug.Log("Releasing a Balloon");
            ReleaseBalloon();
        } else if (balloon != null) {
            Debug.Log("Growing Balloon");
            GrowBalloon();
        }
    }

    private void NewBalloon() {
        balloon = Instantiate(balloonPrefab);
    }

    private void ReleaseBalloon() {
        balloon.GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
        balloon = null;
    }

    private void GrowBalloon() {
        balloon.transform.localScale += balloon.transform.localScale * growRate * Time.deltaTime;
    }
}
