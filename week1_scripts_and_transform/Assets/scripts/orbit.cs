using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
  public Vector3 orbit_speed;

  void Update()
  {
    transform.Rotate(orbit_speed);
  }
}
