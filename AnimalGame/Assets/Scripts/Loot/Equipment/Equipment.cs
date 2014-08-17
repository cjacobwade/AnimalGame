using UnityEngine;
using System.Collections;

public enum EquipEffect
{
	None				= 0,
	AttackSpeed			= 1,	// pants, gloves, weapon
	MoveSpeed			= 2,	// pants, boots
	DamageBoost			= 3,	// pants, gloves, chest, weapon
	ElementalChance		= 4,	// back, ring, weapon
	CritChance			= 5,	// head, ring, weapon
	SpellCooldown		= 6,	// head, ring, weapon
	SpellPower			= 7,	// head, ring, weapon
	SpellRange			= 8,	// head, ring, weapon
	TrapCooldown		= 9,	// gloves, ring
	TrapPower			= 10,	// gloves, ring
	EquipSpell			= 11,	// ring
	EquipTrap			= 12	// pants, ring
	// other effects
}

public class Equipment : LootObj 
{
	public EquipEffect[] equipEffects = new EquipEffect[3];
	public EquipSlot equipSlot;
}
