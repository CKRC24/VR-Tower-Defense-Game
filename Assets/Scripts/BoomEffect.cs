using UnityEngine;
using System.Collections;

public class BoomEffect : MonoBehaviour {
	//ParticleSystem impactEffect = gameObject.GetComponent<ParticleSystem>;
	// Use this for initialization
	float timer = 0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<ParticleSystem>().isPlaying) {
			//print ("A");
			timer +=1;
			if (timer >= 30) {
				timer = 0f;
				//print ("Stop");
				Destroy (gameObject);
			}
			//if (gameObject.GetComponent<ParticleSystem>().particleCount==1) {
				//目前依舊試不出好方法，所以用1，作為結束。因為0似乎會判斷為起始狀態。
				//print ("stop");
				//Destroy (gameObject);
			//}
		}
	}
}
