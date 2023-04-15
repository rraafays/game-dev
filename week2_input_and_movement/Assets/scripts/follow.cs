using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
	public Transform target;
  public float movement_speed;

	void Start()
	{
		Debug.Assert(target != null);
	}

	void Update()
	{
    var above_target = target.position + Vector3.up;

    transform.position = Vector3.Lerp(transform.position, above_target, movement_speed * Time.deltaTime);
	}
}
