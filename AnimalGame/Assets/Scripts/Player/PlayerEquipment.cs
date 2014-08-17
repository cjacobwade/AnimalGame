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

	public Spellbook[] spells = new Spellbook[3];
	public Blueprint[] blueprints = new Blueprint[3];
}
