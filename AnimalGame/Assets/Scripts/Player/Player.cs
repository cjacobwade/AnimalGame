using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public PlayerNavigation pNavigation;
	public PlayerEquipment pEquipment;

	void Awake () 
	{
		pNavigation.SetPlayer(this);
		pEquipment.SetPlayer(this);
	}

	void Update () 
	{
		pNavigation.Tick();
	}
}
