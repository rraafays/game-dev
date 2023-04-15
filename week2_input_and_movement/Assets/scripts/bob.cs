using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour
{
  public float bob_speed;
  public float bob_amount;
  public float pulse_speed;

  void Update()
  {
      transform.localPosition = new Vector3(0, Mathf.Sin(Time.time * bob_speed) * bob_amount, 0);
      transform.localScale = Vector3.one * Mathf.Sin(Time.time * pulse_speed) * 0.5f;
  }
}
