using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
  public Vector3 rotation_speed;

  void Update()
  {
    transform.Rotate(rotation_speed);
  }
}
