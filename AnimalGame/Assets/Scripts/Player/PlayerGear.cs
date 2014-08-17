using UnityEngine;
using System.Collections;

public enum EquipSlot
{
	Head		= 0,
	Chest		= 1,
	Back		= 2,
	Hands		= 3,
	Legs		= 4,
	Feet		= 5,
	Ring		= 6,
	Last		= 7
}

public class PlayerGear : PlayerComponent 
{
	public Weapon weapon;
	public Equipment[] equipment = new Equipment[(int)EquipSlot.Last];
	public Spellbook[] spellbooks = new Spellbook[3];
	public Blueprint[] blueprints = new Blueprint[3];

	public void SetSpellbook(int index, Spellbook spellbook)
	{
		spellbooks[index] = spellbook;
	}

	public void SetBlueprint(int index, Blueprint blueprint)
	{
		blueprints[index] = blueprint;
	}
}
