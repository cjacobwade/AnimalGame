using UnityEngine;
using System.Collections;

public enum NPCEvent
{
	nothing			= 1 << 0,
	becomeHelper	= 1 << 1,
	becomeEnemy		= 1 << 2,
	giveLoot		= 1 << 3,
	playEffect		= 1 << 4,
	disappear		= 1 << 5
}

public class NPC : MonoBehaviour 
{
	public string dialogue;	
	public NPCEvent npcEvent;	// this happens after the dialogue
}
