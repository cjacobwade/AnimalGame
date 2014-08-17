using UnityEngine;
using System.Collections;

public class PlayerCamera : PlayerComponent 
{
	[SerializeField] Transform cam;
	public float followSpeed = 1.0f;
	Vector3 offset;
	
	void Awake()
	{
		offset = transform.position - cam.position;
	}

	public override void Tick()
	{
		cam.position = Vector3.Lerp(cam.position, transform.position - offset, Time.deltaTime * followSpeed);
	}
}
