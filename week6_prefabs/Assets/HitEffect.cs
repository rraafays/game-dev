using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
	void Update()
	{
		// Do some random twitchy rotation effects
		transform.Rotate(Random.onUnitSphere);

		// Slowly grow
		transform.localScale += Vector3.one * Time.deltaTime;

		// Once we reach a certain size "pop" and disappear
		if (transform.localScale.x > 7)
		{
			Destroy(gameObject);
		}
	}
}
