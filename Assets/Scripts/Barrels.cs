using UnityEngine;
using System.Collections;

public class Barrels : MonoBehaviour {

	public int speed = 30;

	//AudioSource barrels;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.I)) {
			//barrels.Play ();
			if (transform.localRotation.eulerAngles.x >= 300 && transform.localRotation.eulerAngles.x <= 360 || transform.localRotation.eulerAngles.x >= -1 && transform.localRotation.eulerAngles.x <= 13) {
				transform.Rotate (Vector3.left * speed * Time.deltaTime);
				Vector3 currentRotation = transform.localRotation.eulerAngles;
				Debug.Log ("Omhoog: " + currentRotation);
			}
		
		}

		if (Input.GetKey (KeyCode.K)) {
			//barrels.Play ();
			if (transform.localRotation.eulerAngles.x >= 298 && transform.localRotation.eulerAngles.x <= 360 || transform.localRotation.eulerAngles.x >= -1 && transform.localRotation.eulerAngles.x <= 12) {
				transform.Rotate (Vector3.right * speed * Time.deltaTime);
				Vector3 currentRotation = transform.localRotation.eulerAngles;
				Debug.Log ("Omlaag: " + currentRotation);
			}
		}
	}
}
