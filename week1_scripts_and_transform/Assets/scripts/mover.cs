using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
  public Vector3 movement_speed;

  void Update()
  {
    transform.position += movement_speed;
  }
}
