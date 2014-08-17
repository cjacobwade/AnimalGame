using UnityEngine;
using System.Collections;

public enum Element
{
	earth		= 1 << 0,
	fire		= 1 << 1,
	ice			= 1 << 2,
	lightning	= 1 << 3,
	poison 		= 1 << 4,
	water		= 1 << 5,
	wind		= 1 << 6
}

public enum SpellEffect
{
	slow		= 1 << 0,
	stun		= 1 << 1,
	knockback	= 1 << 2,
	fear		= 1 << 3
}

public class Spell : MonoBehaviour
{
	public Element element;
	public float duration = 0.0f;
	public GameObject effectPrefab;
	
	public virtual void Awake()
	{
		Invoke("DestroySelf", duration);
	}
	
	public virtual void DestroySelf()
	{
		Destroy(gameObject);
	}
}
