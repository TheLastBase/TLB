using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AI_Zombie : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public Animator animator;
	private bool alive;
	//public Collider aliveCollider;
	//public Collider deadCollider;
	public Transform myTransfrom;
	public Text counter;
	public Collider zombieCollider;
	public Collider terrainCollider;
	private Random random;

	// Use this for initialization
	void Start () {
		alive = true;
		animator.SetFloat ("Random", Random.Range(0.0f,2.0f));
	}
	
	// Update is called once per frame
	void Update () {
		//Physics.IgnoreCollision (terrainCollider, zombieCollider);
		if (alive == true) {
			myTransfrom.rotation = Quaternion.Slerp (myTransfrom.rotation, Quaternion.LookRotation (target.position - myTransfrom.position), rotationSpeed * Time.deltaTime);
			myTransfrom.position += myTransfrom.forward * moveSpeed * Time.deltaTime;
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Shell(Clone)"){
		Debug.Log ("Collided with " + other.gameObject.name);
		animator.SetTrigger ("Hit");
		alive = false;
		}
	}
}
