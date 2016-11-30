using UnityEngine;
using System.Collections;

public class BallShoot : MonoBehaviour {
	public GameObject ball; //reference to the ball prefab, set in editor
	private bool thrown = false; //if ball has been thrown, prevents 2 or more balls
	private GameObject ballClone; //we don't use the original prefab
	private Rigidbody rb;
	public Camera cam_other;
	float pressure = 10f;
	float max = 50f;



	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3 (0, -20, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(cam_other.enabled){
			if (Input.GetKey ("space")) {
				pressure += Time.deltaTime * 30f;
				//print (pressure);
			}
			if (Input.GetKeyUp("space") && !thrown)
			{
			//thrown = true;
				if(pressure>max){
					pressure=max;
				}
					
				ballClone = Instantiate (ball, transform.position, transform.rotation) as GameObject;
				rb = ballClone.GetComponent<Rigidbody> ();
				Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));

				//rb.AddForce(throwSpeed, ForceMode.Impulse);
				rb.AddForce (ray.direction  *pressure, ForceMode.Impulse);
				pressure = 10f;
			
			}
		//if (ballClone != null && ballClone.transform.position.y < -16)
		//{
		//	Destroy(ballClone);
		//	thrown = false;
		//	throwSpeed = new Vector3(0, 26, 40);//Reset perfect shot variable
		//}
		}
	}
}
