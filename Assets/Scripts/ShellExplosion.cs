using UnityEngine;
using System.Collections;

public class ShellExplosion : MonoBehaviour {

	//public Transform shell;
	//public Transform explosionPrefab;

	void OnCollisionEnter(Collision collision){
		//ContactPoint contact = collision.contacts [0];
		//Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
		//Vector3 pos = contact.point;
		//Instantiate (explosionPrefab, pos, rot);
		Destroy (gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
