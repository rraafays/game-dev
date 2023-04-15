using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed;
    public Vector3 TurnSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.position += transform.forward * MovementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) transform.position -= transform.forward * MovementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.Rotate(-TurnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Rotate(TurnSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
