using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulser : MonoBehaviour
{
  void Update()
  {
    transform.localScale = Vector3.one * Mathf.Sin(Time.time);
  }
}
