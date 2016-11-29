using UnityEngine;
using System.Collections;

public class UponEnter : MonoBehaviour
{
	public int scoreValue = 50;

	void OnTriggerEnter(Collider other)
	{
		ScoreManager.score += scoreValue;
	}
}