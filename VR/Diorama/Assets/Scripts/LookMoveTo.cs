using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour {
    public GameObject ground;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DrawCursorByAvoidingObstacles();
    }

    private void DrawCursor() {
        Transform camera = Camera.main.transform;

        RaycastHit raycastHit;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward * 100.0f);

        if (Physics.Raycast(ray, out raycastHit)) {
            GameObject objectHit = raycastHit.collider.gameObject;

            if (objectHit == ground) {
                Debug.Log("Hit (x, y, z):" + raycastHit.point.ToString("F2"));
                this.transform.position = raycastHit.point;
            }
        }
    }

    private void DrawCursorByAvoidingObstacles() {
        Transform camera = Camera.main.transform;

        RaycastHit[] raycastHits;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward * 100.0f);

        raycastHits = Physics.RaycastAll(ray);

        for(int iter = 0; iter < raycastHits.Length; iter++) {
            RaycastHit raycastHit = raycastHits[iter];
            GameObject objectHit = raycastHit.collider.gameObject;

            if (objectHit == ground) {
                Debug.Log("Hit (x, y, z):" + raycastHit.point.ToString("F2"));
                this.transform.position = raycastHit.point;
            }

        }
    }
}
