using UnityEngine;
using System.Collections;

public class Right_Flipper : MonoBehaviour {

	private Quaternion startingRotation;
	public float rot = 0;
	public float rotSpeed = 0;

	public float force = 100.0f;
	public float forceRadius = 10f;
	public int scoreValue = 100;

	// Use this for initialization
	void Start () {
		startingRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("right")){
			FlipperRotation ();
			OnCollisionEnter ();
		}
		else if (Input.GetKeyUp("right"))
			transform.rotation = startingRotation;
	}

	void FlipperRotation()
	{
		float _tempTime = -15;
		_tempTime += Time.deltaTime;
		transform.localEulerAngles = new Vector3 (0, Mathf.PingPong (_tempTime * rotSpeed, rot), 0);
	}

	void OnCollisionEnter()
	{
		foreach(Collider col in Physics.OverlapSphere(transform.position, forceRadius))
		{
			if(col.GetComponent<Rigidbody>())
			{
				col.GetComponent<Rigidbody>().AddExplosionForce(force,transform.position,forceRadius);
			}
		}

		//ScoreManager.score += scoreValue;
	}
}
