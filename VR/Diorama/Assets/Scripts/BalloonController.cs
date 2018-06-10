using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour {
    public GameObject meMyselfEye;
    private MyInputController inputController;

    public GameObject balloonPrefab;
    private GameObject balloon;

    public float floatStrength = 20f;

    public float growRate = 1.5f;

	// Use this for initialization
	void Start () {
        inputController = meMyselfEye.GetComponent<MyInputController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (inputController.ButtonDown()) {
            NewBalloon();
        }
        else if (inputController.ButtonUp()) {
            ReleaseBalloon();
        }
        else if (balloon != null) {
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
