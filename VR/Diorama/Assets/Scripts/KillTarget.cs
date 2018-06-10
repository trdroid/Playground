using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTarget : MonoBehaviour {
    public GameObject target;
    public GameObject killEffect;
    public ParticleSystem hitEffect;
    
    public int score;

    public float timeToSelect = 3.0f;
    private float countDown;

	// Use this for initialization
	void Start () {
        score = 0;
        countDown = timeToSelect;
	}
	
	// Update is called once per frame
	void Update () {
        Transform cameraTransformComponent = Camera.main.transform;

        Ray ray = new Ray(cameraTransformComponent.position, cameraTransformComponent.rotation * Vector3.forward);

        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit) && (raycastHit.collider.gameObject == target)) {
            if (countDown > 0.0f) {
                countDown -= Time.deltaTime;
                hitEffect.transform.position = raycastHit.point;
                hitEffect.Play();
            } else {
                Instantiate(killEffect, target.transform.position, target.transform.rotation);
                score += 1;
                countDown = timeToSelect;
                SetRandomPosition();
            }
        } else {
            countDown = timeToSelect;
            hitEffect.Stop();
        }
	}

    void SetRandomPosition() {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);

        Debug.Log("X, Z:" + x.ToString("F2") + ", " + z.ToString("F2"));

        transform.position = new Vector3(x, 0.0f, z);
    }
}
