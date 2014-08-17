using UnityEngine;
using System.Collections;

public class PlayerStatsHub : PlayerComponent 
{
	PlayerStats pDefaultStats = new PlayerStats();
	PlayerStats pCurrentStats = new PlayerStats();

	PlayerGear pGear;

	[SerializeField] float attackSpeedMultiplier = 1.3f;
	[SerializeField] float moveSpeedMultiplier = 1.3f;
	[SerializeField] float elementalChanceIncrement = 5.0f;
	[SerializeField] float critChanceIncrement = 5.0f;

	void Awake()
	{
		pGear = GetComponent<PlayerGear>();
		pGear.SetPlayer(player);
	}

	public PlayerStats GetCurrentStats()
	{
		pCurrentStats = pDefaultStats;

		foreach(Equipment equipment in pGear.equipment)
		{
			foreach(EquipEffect equipEffect in equipment.equipEffects)
			{
				switch(equipEffect)
				{
				case EquipEffect.AttackSpeed:
					pCurrentStats.moveSpeed *= attackSpeedMultiplier;
					break;
				case EquipEffect.MoveSpeed:
					pCurrentStats.moveSpeed *= moveSpeedMultiplier;
					break;
				case EquipEffect.DamageBoost:
					pCurrentStats.damageBoost++;
					break;
				case EquipEffect.ElementalChance:
					pCurrentStats.elementalChance += elementalChanceIncrement;
					break;
				case EquipEffect.CritChance:
					pCurrentStats.critChance += critChanceIncrement;
					break;
				case EquipEffect.SpellCooldown:
					pCurrentStats.spellCooldown++;
					break;
				case EquipEffect.SpellPower:
					pCurrentStats.spellPower++;
					break;
				case EquipEffect.SpellRange:
					pCurrentStats.spellRange++;
					break;
				case EquipEffect.TrapCooldown:
					pCurrentStats.trapCooldown++;
					break;
				case EquipEffect.TrapPower:
					pCurrentStats.trapPower++;
					break;
				case EquipEffect.EquipSpell:
					if(equipment is Spellbook)
					{
						pCurrentStats.equipSpell = ((Spellbook)equipment).spell;
					}
					else
					{
						Debug.LogError("Equip Effect: Equip Spell is being used on a Non-Spellbook.");
					}
					break;
				case EquipEffect.EquipTrap:
//					if(equipment is Blueprint)
//					{
//						pCurrentStats.equipTrap = ((Blueprint)equipment).trap;
//					}
//					else
//					{
//						Debug.LogError("Equip Effect: Equip Trap is being used on a Non-Blueprint.");
//					}
					break;
				}
			}
		}

		return pCurrentStats;
	}

	void OnGUI()
	{
		GUI.TextField(new Rect(0.0f, 0.0f, Screen.width/5.0f, Screen.height/15.0f), pCurrentStats.health.ToString());
	}
}
