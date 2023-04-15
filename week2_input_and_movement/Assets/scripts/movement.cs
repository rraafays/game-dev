using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float movement_speed;
	private Vector3 target_position;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.H)) target_position += Vector3.left;
		if (Input.GetKeyDown(KeyCode.J)) target_position += Vector3.back;
		if (Input.GetKeyDown(KeyCode.K)) target_position += Vector3.forward;
		if (Input.GetKeyDown(KeyCode.L)) target_position += Vector3.right;

		transform.position = Vector3.Lerp(transform.position, target_position, movement_speed * Time.deltaTime);
	}
}
