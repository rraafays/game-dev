using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
	public float Speed;
	public Vector3 Direction;  // this will be set at runtime in ShipMovementController
	public float CountdownToDeath;

	void Update()
	{
        // Move in our direction
		transform.position += Direction * Speed * Time.deltaTime;

        // Subtract from the countdown timer
		CountdownToDeath -= Time.deltaTime;

        // If we hit zero it's time to destroy the object
		if (CountdownToDeath <= 0)
		{
			Destroy(gameObject);
		}
	}
}
