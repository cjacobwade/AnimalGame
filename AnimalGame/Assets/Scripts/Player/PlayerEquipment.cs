using UnityEngine;
using System.Collections;

public class PlayerEquipment : PlayerComponent 
{
	public Equipment head;
	public Equipment chest;
	public Equipment gloves;
	public Equipment pants;
	public Equipment boots;
	public Equipment back;
	public Equipment ring;

	public Weapon weapon;

	Spellbook[] spellbooks = new Spellbook[3];
	Blueprint[] blueprints = new Blueprint[3];

	public void SetSpellbook(int index, Spellbook spellbook)
	{
		spellbooks[index] = spellbook;
	}

	public void SetBlueprint(int index, Blueprint blueprint)
	{
		blueprints[index] = blueprint;
	}
}
