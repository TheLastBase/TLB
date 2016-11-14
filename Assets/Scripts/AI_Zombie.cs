using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AI_Zombie : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public Animator animator;
	private bool alive;
	//public Collider hitbox;
	//public Collider aliveCollider;
	//public Collider deadCollider;
	public Transform myTransfrom;
	public Transform parent;
	public Text counter;

	// Use this for initialization
	void Start () {
		counter = GetComponent<Text> ();
		alive = true;
		//hitbox.enabled = true;
		//aliveCollider.enabled = false;
		//deadCollider.enabled = false;
		int counterInt = parent.childCount;
		counter.text = (counterInt.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		if (alive == true) {
			myTransfrom.rotation = Quaternion.Slerp (myTransfrom.rotation, Quaternion.LookRotation (target.position - myTransfrom.position), rotationSpeed * Time.deltaTime);
			myTransfrom.position += myTransfrom.forward * moveSpeed * Time.deltaTime;
			//aliveCollider.enabled = true;
			//deadCollider.enabled = false;
		}
	}

	void OnTriggerEnter (Collider other){
		animator.SetTrigger ("Hit");
		alive = false;
		//aliveCollider.enabled = true;
		//deadCollider.enabled = false;
	}
}
