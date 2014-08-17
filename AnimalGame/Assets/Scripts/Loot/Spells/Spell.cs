using UnityEngine;
using System.Collections;

public enum Element
{
	none		= 1 << 0,
	earth		= 1 << 1,
	fire		= 1 << 2,
	ice			= 1 << 3,
	lightning	= 1 << 4,
	poison 		= 1 << 5,
	water		= 1 << 6,
	wind		= 1 << 7
}

public enum SpellEffectType
{
	none		= 1 << 0,
	slow		= 1 << 1,
	stun		= 1 << 2,
	knockback	= 1 << 3,
	fear		= 1 << 4
}

public struct SpellEffect
{
	public float duration;
	public SpellEffectType effectType;
}

public class Spell : MonoBehaviour
{
	public Element element;
	public SpellEffect[] spellEffects;
	public GameObject effectPrefab;
}
