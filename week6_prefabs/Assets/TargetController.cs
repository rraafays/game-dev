using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    float offset;
    float speed;
    bool movement = true;

    void OnTriggerEnter(Collider other)
    {
        // We've been hit! We could get hit multiple times so
        // disable our collider so no more hits are registered
        GetComponent<BoxCollider>().enabled = false;

        // Add the HitEffect component which will eventually destroy us
        gameObject.AddComponent<HitEffect>();

		// Stop the movement
        movement = false;
    }

    void Start()
    {
        // Randomise the bobbing movement a little otherwise
        // everything bobs in unison and it looks boring
        offset = Random.value * 100;
        speed = Random.Range(5f, 15f);
    }

    void Update()
    {
        if (movement)
        {
            // Bob up and down
            transform.position += Mathf.Sin(Time.time * speed + offset) * Vector3.up * 0.4f;
        }
    }
}