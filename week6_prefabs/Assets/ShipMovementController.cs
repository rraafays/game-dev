using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementController : MonoBehaviour
{
	public float ThrustPower;
	public float RotatePower;
	public float BulletSpread;
	public GameObject BulletPrefab;
	public Transform BulletsParent;

	void Update()
	{
		// If we shoot a laser
		if (Input.GetKey(KeyCode.Space))
		{
            // Fire 1 laser from each turret
            for (int i = 0; i <= 1; i++)
            {
                // Create a bullet prefab
                var bullet = Instantiate(BulletPrefab, transform.GetChild(i).position + transform.forward * 2, Quaternion.identity);

				// Set its parent to keep the Hierarchy tidy in Unity
				bullet.transform.parent = BulletsParent;

                // And set its direction to match ours when we shot it, with some spread randomness
                var direction = transform.forward + Random.insideUnitSphere * BulletSpread * 0.01f;
                bullet.GetComponent<BulletController>().Direction = direction;
            }
		}

        // Standard physics based movement handling
		if (Input.GetKey(KeyCode.W))
		{
			GetComponent<Rigidbody>().AddForce(transform.forward * ThrustPower);
		}

		if (Input.GetKey(KeyCode.S))
		{
			GetComponent<Rigidbody>().AddForce(-transform.forward * ThrustPower);
		}

		if (Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody>().AddTorque(-transform.up * RotatePower);
		}

		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody>().AddTorque(transform.up * RotatePower);
		}
	}
}