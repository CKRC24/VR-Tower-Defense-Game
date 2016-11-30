using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public Camera myself;
	public GameObject player;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		myself.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space")){
			Ray ray = myself.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
			rb = player.GetComponent<Rigidbody> ();
			rb.AddForce(ray.direction , ForceMode.VelocityChange);
		}

	}
}
