using UnityEngine;
using System.Collections;

public class KillBox : MonoBehaviour
{
	public string destroyTag = "Ball";

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == destroyTag)
		{
			Destroy(col.gameObject);
			print ("de");
		}
	}
}
