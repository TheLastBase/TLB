using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	public Texture2D crosshairImage;
	public Camera turretCam;
	private int crosshairSize = 5;
	//int zoomSpeed = 5;
	//int minFOV = 20;
	//int maxFOX = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.KeypadPlus)){
			if (crosshairSize >= 5) {
				crosshairSize = crosshairSize - 1;
			}
		}
		if (Input.GetKey (KeyCode.KeypadMinus)) {
			if (crosshairSize < 15) {
				crosshairSize = crosshairSize + 1;
			}
		}
		// assign zoom value to a variable
		//float delta = Input.GetAxis ("Zoom") * -zoomSpeed;
		//if(Input.GetButton ("Zoom"))
		//{
			// make sure the current FOV is within min/max values
			//if((turretCam.fieldOfView + delta > minFOV)
				//(turretCam.fieldOfView + delta < maxFOV))
			//{
				// apply the change to the main camera
				//turretCam.fieldOfView = turretCam.current.fieldOfView + delta;
				//print ("FOV: " + turretCam.fieldOfView);
			//}
		//}
	}

	void OnGUI(){
		if (turretCam.enabled == true) {
			float xMin = (Screen.width / 2) - (crosshairImage.width/(2*crosshairSize));
			float yMin = (Screen.height / 2) - (crosshairImage.height/(2*crosshairSize));
			GUI.DrawTexture (new Rect (xMin - 5 , yMin, crosshairImage.width/crosshairSize, crosshairImage.height/crosshairSize), crosshairImage);
			GUI.DrawTexture (new Rect (xMin + 5 , yMin, crosshairImage.width/crosshairSize, crosshairImage.height/crosshairSize), crosshairImage);
		}
	}
}
