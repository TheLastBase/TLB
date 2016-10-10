using UnityEngine;
using System.Collections;

public class FPSInputController : MonoBehaviour {



	//Public float's for mouse
	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
	//Float for mouse
	float rotationY = 0F;
	//Public float's for keyboard
	public float speed = 7.0f;
	public float jumpSpeed = 6.0f;
	public float gravity = 20.0f;
	//Public bool for keyboard
	public bool controllable = false;
	//Private for keyboard
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;



	void Start ()
	{
		controller = GetComponent<CharacterController>();
		// Make the rigid body not change rotation
		//rigid = GetComponent<Rigidbody>();
		//rigid.constraints = Rigidbody.FreezeRotationX;
	}



	void Update ()
	{
		if (axes == RotationAxes.MouseXAndY)
		{
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
		}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}

		if (controller.isGrounded && controllable)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}