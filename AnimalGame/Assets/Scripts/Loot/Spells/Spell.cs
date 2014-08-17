using UnityEngine;
using System.Collections;

public enum Element
{
	None		= 1 << 0,
	Earth		= 1 << 1,
	Fire		= 1 << 2,
	Ice			= 1 << 3,
	Lightning	= 1 << 4,
	Poison 		= 1 << 5,
	Water		= 1 << 6,
	Wind		= 1 << 7
}

public enum SpellEffectType
{
	None		= 1 << 0,
	Slow		= 1 << 1,
	Stun		= 1 << 2,
	Knockback	= 1 << 3,
	Fear		= 1 << 4
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
