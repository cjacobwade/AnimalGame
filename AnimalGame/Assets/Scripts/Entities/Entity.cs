using UnityEngine;
using System.Collections;



[SerializeField]
public struct LootDrop
{
	public LootObj loot;
	public float dropChance;
}

public class Entity : MonoBehaviour 
{
	public string entityName;

	public int health;
	public Attack[] attacks;

	protected NavMeshAgent navMeshAgent;
	protected EntityFSMSystem fsm;

	public float lookDistance = 10.0f;
	public GameObject target;

	public LootDrop[] lootDrops;

	public Element element;
	public Element weaknesses;
	public Element resistances;

	void Awake()
	{
		MakeFSM();
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	public virtual void MakeFSM()
	{
	
	}

	public void SetNavDestination(Vector3 pos)
	{
		navMeshAgent.SetDestination(pos);
	}
	
	public void DoStateTransition(EntityTransition entityTransition)
	{
		fsm.PerformTransition(entityTransition);
	}
}