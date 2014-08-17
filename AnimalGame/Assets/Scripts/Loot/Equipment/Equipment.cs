using UnityEngine;
using System.Collections;

public enum EquipEffect
{
	attackSpeed,		// pants, gloves, weapon
	moveSpeed,			// pants, boots
	damageBoost,		// pants, gloves, chest, weapon
	elementalChance,	// back, ring, weapon
	critChance,			// head, ring, weapon
	spellCooldown,		// head, ring, weapon
	spellPower,			// head, ring, weapon
	spellRange,			// head, ring, weapon
	trapCooldown,		// gloves, ring
	trapPower,			// gloves, ring
	equipSpell,			// ring
	equipTrap			// pants, ring
	// other effects
}

public class Equipment : LootObj 
{
	public EquipEffect[] equipEffects = new EquipEffect[3];
}
