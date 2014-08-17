using UnityEngine;
using System.Collections;

public class PlayerStats
{
	public string playerName = "Name";
	public int health = 25;
	
	public float moveSpeed = 5.0f;
	public float attackSpeedMod = 1.0f;
	
	public int damageBoost = 1;
	
	public float elementalChance = 0.0f;
	public float critChance = 5.0f;
	
	public int spellCooldown = 1;
	public int spellPower = 1;
	public int spellRange = 1;
	
	public int trapCooldown = 1;
	public int trapPower = 1;
	
	public Spell equipSpell;
	//public Trap equipTrap;
}
