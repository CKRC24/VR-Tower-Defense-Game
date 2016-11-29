using UnityEngine;
using System.Collections;

public class BallStart : MonoBehaviour {

	public GameObject ball;
	private GameObject moreball;

	//public float force = 100.0f;
	//public float forceRadius = 1.0f;

	// Use this for initialization
	void Start () {
		moreball = Instantiate (ball, transform.position, transform.rotation) as GameObject;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			Rigidbody ballforce = moreball.GetComponent<Rigidbody> ();
			ballforce.AddForce (0,0,40,ForceMode.Impulse);
			//ballforce.AddExplosionForce(force,transform.position,forceRadius);
		}
		if (moreball == null) {
			moreball = Instantiate (ball, transform.position, transform.rotation) as GameObject;
		}
	}
}
