using UnityEngine;
using System.Collections;


public class Bumper : MonoBehaviour {
	public ParticleSystem impactEffect;
	public float force = 100000.0f;
	public float forceRadius = 100.0f;
	public GameObject boom;
	private GameObject boomclone;

	void Start () {
		boom.GetComponent<ParticleSystem>().Stop();
	}
	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Enemy") {
			//限定只對敵人有效
			other.gameObject.GetComponent<NavMeshAgent> ().enabled = false;
			other.rigidbody.AddExplosionForce(force, transform.position, forceRadius,1.0f,ForceMode.Impulse);
			//第一個參數是大小（每幀）
			//第二個參數是位置
			//第三、四個參數很難描述ＸＤ
			//if (other.GetComponent<Rigidbody> ()) {
			//	other.GetComponent<Rigidbody> ().AddExplosionForce (force, transform.position, forceRadius);
			//}
			//boom.GetComponent<ParticleSystem>().transform.position = other.gameObject.transform.position;
			boomclone = Instantiate(boom,transform.position,transform.rotation)as GameObject;
			//boomclone.GetComponent<ParticleSystem>().transform.position = new Vector3(-4,2,9);
			//boom.GetComponent<ParticleSystem>().transform.rotation = Quaternion.Euler(270, 0, 0);
			//impactEffect.Stop();
			boomclone.GetComponent<ParticleSystem>().Stop();
			boomclone.GetComponent<ParticleSystem>().Play();
			//Destroy (boomclone);
			Destroy(gameObject);
			//球碰到坦克後會消失
		}
	}
}
