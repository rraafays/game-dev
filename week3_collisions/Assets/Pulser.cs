using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulser : MonoBehaviour
{
    private float PulseSpeed;

    void Start()
    {
        PulseSpeed = Random.Range(1f, 2f);
    }

    void Update()
    {
        float minusOneToOne = Mathf.Sin(Time.time * PulseSpeed);
        float zeroToTwo = minusOneToOne + 1;
        float zeroToOneQuarter = zeroToTwo / 8;
        float oneQuarterToOneHalf = zeroToOneQuarter + 0.25f;
        transform.localScale = Vector3.one * oneQuarterToOneHalf; 
    }
}
