using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;
	//var cam1  Camera;
	//var cam2  Camera;

	void Start() {
		cam1.enabled = true;
		cam2.enabled = false;
	}

	void Update() {

		if (Input.GetKeyDown(KeyCode.C)) {
			cam1.enabled = !cam1.enabled;
			cam2.enabled = !cam2.enabled;
		}
		if (Input.GetKey ("s")) {
			cam1.enabled = false;
			cam2.enabled = false;
		}
		if (Input.GetKey ("d")) {
			cam1.enabled = true;
		}
	}
}
