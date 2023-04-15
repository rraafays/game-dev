using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roof_hider : MonoBehaviour
{
    private float target_opacity = 1;

    // Called when the player walks under the roof
    private void OnTriggerEnter(Collider other)
    {
        target_opacity = 0;
    }

    // Called when the walks out from under the roof
    private void OnTriggerExit(Collider other)
    {
        target_opacity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Grab a reference to the roof's material
        var material = GetComponent<MeshRenderer>().material;
        
        // Grab a copy of the material's colour so we can change one channel of the colour
        var colour = material.color;

        // Smoothly move the alpha channel towards the target
        colour.a = Mathf.Lerp(colour.a, target_opacity, Time.deltaTime * 5);

        // Save it back onto the material
        material.color = colour;
    }
}
