using UnityEngine;
using System.Collections;

public class PlayerNavigation : PlayerComponent 
{
	NavMeshAgent navMeshAgent;
	[SerializeField] LayerMask navLayer;

	Transform target;

	void Awake()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	public override void Tick()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = WadeUtils.RaycastAndGetInfo(ray, navLayer, Mathf.Infinity);

			if(hit.transform)
			{
				if(hit.transform.CompareTag("Target"))
				{
					target = hit.transform;
				}
				else if(hit.transform.CompareTag("Environment"))
				{
					target = null;
					navMeshAgent.SetDestination(hit.point);
				}
			}
		}

		if(target && Time.frameCount % 30 == 0)
		{
			navMeshAgent.SetDestination(target.position);
		}
	}
}
