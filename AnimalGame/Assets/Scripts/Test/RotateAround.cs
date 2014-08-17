using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour 
{
	[SerializeField] float speed;

	void Update () 
	{
		transform.RotateAround(transform.parent.position, Vector3.up, speed * Time.deltaTime);
	}
}
