using UnityEngine;

public class EnemyNavigation : MonoBehaviour {

	public Transform target;	//目標
	NavMeshAgent agent;			//尋徑物件
	float timer=0f;

	void Start()
	{
		//找到物體身上的尋徑元件
		agent = GetComponent<NavMeshAgent> ();
    }

	void Update()
	{
		//不斷的向目標前進
		if (target && !agent.hasPath)
		{
			agent.SetDestination(target.position);
		}
		print (agent.isActiveAndEnabled);
		print ("AAAA");
		if (!agent.isActiveAndEnabled) {
			//print (timer);
			timer +=1;
			if (timer >= 30) {
				timer = 0f;
				agent.enabled = true;
				print ("OK");
				//print (agent.isActiveAndEnabled);
			}
		}
	}

}
