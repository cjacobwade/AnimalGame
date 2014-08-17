using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public PlayerNavigation pNavigation;
	public PlayerEquipment pEquipment;
	public PlayerStats pStats;

	void Awake () 
	{
		pNavigation.SetPlayer(this);
		pEquipment.SetPlayer(this);
		pStats.SetPlayer(this);
	}

	void Update () 
	{
		pNavigation.Tick();
		pStats.Tick();
	}
}
