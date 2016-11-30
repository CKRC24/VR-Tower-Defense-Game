using UnityEngine;
using System.Collections;

public class SwitchMode : MonoBehaviour {
	public GameObject player;
	private GameObject playerclone;
	public Camera ViewofWorld;
	bool isModeSwitch = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("s") && !isModeSwitch) {
			isModeSwitch = true;
			playerclone = Instantiate (player, transform.position, transform.rotation) as GameObject;
			//CameraController.cam1.enabled = false;
			//CameraController.cam2.enabled = false;

		}
		if (Input.GetKey ("d") && isModeSwitch) {
			isModeSwitch = false;
			Destroy (playerclone);
		}

	
	}
}
