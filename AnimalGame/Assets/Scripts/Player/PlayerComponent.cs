using UnityEngine;
using System.Collections;

public class PlayerComponent : MonoBehaviour
{
	protected Player player;

	virtual public void Tick()
	{

	}

	public void SetPlayer(Player inPlayer)
	{
		player = inPlayer;
	}
}
