using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	public int speed = 30;
	public Camera turretCam;
	public Camera mainCam;
	public GameObject player;
	public GameObject turret;
	private bool insideTurret;
	public GameObject exitpoint;

	// Use this for initialization
	void Start () {
		mainCam.enabled = true;
		turretCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J)) {
			transform.Rotate (Vector3.down * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.L)) {
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		}
	
		if (Input.GetKey (KeyCode.O)) {
			turretCam.enabled = true;
			mainCam.enabled = false;
			insideTurret = true;

		}
		if (Input.GetKey (KeyCode.U)) {
			mainCam.enabled = true;
			turretCam.enabled = false;
			insideTurret = false;
			player.transform.position = exitpoint.transform.position;
			player.transform.rotation = exitpoint.transform.rotation;
		}
		if (insideTurret == true) {
			player.transform.position = turret.transform.localPosition;
		}
	}
}
