using UnityEngine;
using System.Collections;

public class PlayerStats : PlayerComponent 
{
	public string playerName;

	public int health = 25;

	public int moveSpeed;
	public float attackSpeed;

	public int damageBoost;

	public float elementalChance;
	public float critChance;

	public float spellCooldown;
	public int spellPower;
	public int spellRange;

	public float trapCooldown;
	public int trapPower;

	public Spell equipSpell;
	//public Trap equipTrap;

	public override void Tick ()
	{

	}

	void OnGUI()
	{
		GUI.TextField(new Rect(0.0f, 0.0f, Screen.width/5.0f, Screen.height/15.0f), health.ToString());
	}
}
