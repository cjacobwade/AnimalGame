using UnityEngine;
using System.Collections;

public enum EnemyType
{
	trash,
	medium,
	miniBoss,
	boss
}

public class Enemy : Entity 
{
	public EnemyType enemyType = EnemyType.trash;
	public float maxChaseDistance = 15.0f;

	public float followTime = 0.0f;
	public float patrolTime = 0.0f;

	void Update()
	{
		if(fsm.CurrentStateID == EntityStateID.patrol)
		{
			patrolTime += Time.deltaTime;
			followTime = 0.0f;
		}
		else
		{
			followTime += Time.deltaTime;
			patrolTime = 0.0f;
		}

		fsm.CurrentState.Act(this);
		fsm.CurrentState.Reason(this);
	}

	public override void MakeFSM()
	{
		EnemyPatrolState patrol = new EnemyPatrolState();
		patrol.AddTransition(EntityTransition.targetSpotted, EntityStateID.chase);
		
		EnemyChaseState chase = new EnemyChaseState();
		chase.AddTransition(EntityTransition.lostTarget, EntityStateID.patrol);
		
		fsm = new EntityFSMSystem();
		fsm.AddState(patrol);
		fsm.AddState(chase);
	}
}

public class EnemyPatrolState : EntityFSMState
{
	public EnemyPatrolState()
	{
		entityStateID = EntityStateID.patrol;
	}

	public override void Reason (Entity entity)
	{
		if(entity is Enemy)
		{
			if(((Enemy)entity).patrolTime < 3.0f)
			{
				return;
			}
		}

		Ray ray = new Ray(entity.transform.position, entity.transform.forward);
		RaycastHit hit = WadeUtils.RaycastAndGetInfo(ray, entity.lookDistance);

		if(!hit.transform)
		{
			return;
		}

		if(hit.transform.CompareTag("Player") || hit.transform.CompareTag("Helper"))
		{
			entity.target = hit.transform.gameObject;
			entity.DoStateTransition(EntityTransition.targetSpotted);
		}
	}
	
	public override void Act (Entity entity)
	{
		// Need to implement patrol
	}
}

public class EnemyChaseState : EntityFSMState
{
	public EnemyChaseState()
	{
		entityStateID = EntityStateID.chase;
	}

	public override void Reason (Entity entity)
	{
		if(entity is Enemy)
		{
			Enemy enemy = (Enemy)entity;
			if(Vector3.Distance(enemy.target.transform.position, entity.transform.position) > enemy.maxChaseDistance || enemy.followTime > 5.0f)
			{
				enemy.target = null;
				enemy.DoStateTransition(EntityTransition.lostTarget);
			}
		}
	}
	
	public override void Act (Entity entity)
	{
		entity.SetNavDestination(entity.target.transform.position);
	}
}