using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody shell;
	public Transform Barrels;
	public Transform fireSpawn;
	public AudioSource shootingAudio;
	public AudioClip fire;
	public GameObject fireBall;
	public float launchForce = 15f;
	public int playerNumber = 1;

	private string fireButton;
	private float shellSpeed;
	private bool fired;

	// Use this for initialization
	void Start () {
		fireButton = "Fire" + playerNumber;
	}
	
	// Update is called once per frame
	void Update () {
		if (!fired) {
			//not fired
			Fire();
		} else if (Input.GetButtonDown (fireButton)) {
			//first time?
			fired = false;
		} else if (Input.GetButton (fireButton) && !fired) {
			//holding fire button, not yet fired
		} else if (Input.GetButtonUp (fireButton) && !fired) {
			//we released the button, having not fired yet
			Fire ();
		}
	}

	private void Fire()
	{
		fired = true;

		Rigidbody shellInstance = Instantiate (shell, fireSpawn.position, fireSpawn.rotation) as Rigidbody;
		//shellInstance.transform.parent = Barrels.transform;
		shellInstance.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);

		shellInstance.velocity = launchForce * fireSpawn.forward;

		//StartCoroutine(Explosion());
		shootingAudio.clip = fire;
		shootingAudio.Play ();
	}

	//IEnumerator Explosion()
	//{
		//FireBall 

		//yield return new WaitForSeconds(1);

		//fireBall.SetActive (false);
	//}
}
