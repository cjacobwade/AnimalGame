using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public PlayerNavigation pNavigation;
	public PlayerCamera pCamera;
	public PlayerStatsHub pStatsHub;

	void Awake () 
	{
		pNavigation.SetPlayer(this);
		pCamera.SetPlayer(this);
		pStatsHub.SetPlayer(this);
	}

	void Update () 
	{
		pNavigation.Tick();
		pCamera.Tick();
		pStatsHub.Tick();
	}

	public void GetCurrentStats()
	{

	}
}
