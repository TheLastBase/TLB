using UnityEngine;
using System.Collections;

public class AI_Zombie : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransfrom;

	void Awake(){
		myTransfrom = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
	
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawLine (target.position, myTransfrom.position, Color.yellow);

		myTransfrom.rotation = Quaternion.Slerp (myTransfrom.rotation, Quaternion.LookRotation (target.position - myTransfrom.position), rotationSpeed * Time.deltaTime);

		myTransfrom.position += myTransfrom.forward * moveSpeed * Time.deltaTime;
	
	}
}
