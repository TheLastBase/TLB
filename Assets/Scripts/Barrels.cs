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
		
		if (Input.GetKey (KeyCode.I))
			//barrels.Play ();
			transform.Rotate (Vector3.left * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.K))
			//barrels.Play ();
			transform.Rotate (Vector3.right * speed * Time.deltaTime);
	}
}
