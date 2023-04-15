using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
  public float movement_speed;
  public Transform stamina_bar;
  public float stamina; // percentage
  public float stamina_regain;
  public float move_cost;
  private float max_stamina;

  void Start()
  {
    max_stamina = stamina_bar.localScale.x;
    stamina = 1;
  }

  void Update()
  {
    Vector3 movement = Vector3.zero;

    if (stamina >= move_cost * Time.deltaTime)
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }
    }

    // If we did press something
    if (movement.sqrMagnitude > 0)
    {
        // Reduce our stamina
        stamina -= move_cost * Time.deltaTime;

        // Move without going faster diagonally
        transform.position += Time.deltaTime * movement_speed * movement.normalized;
    }

    // Regain a bit of stamina every frame
    stamina += stamina_regain * Time.deltaTime;

    // Either way, make sure it stays between 0 and 1
    stamina = Mathf.Clamp01(stamina);

    // Set the width of the on-screen display
    var scale = stamina_bar.localScale;
    scale.x = stamina * max_stamina;
    stamina_bar.localScale = scale;

    // Set the colour of the on-screen stamina bar by changing the hue
    var material = stamina_bar.GetComponent<MeshRenderer>().material;
    material.color = Color.HSVToRGB(stamina * 0.3f, 1, 1);

    // And finally the ability for the player to customise their appearance
    if (Input.GetKeyDown(KeyCode.R)) GetComponent<MeshRenderer>().material.color = Color.red;
    if (Input.GetKeyDown(KeyCode.G)) GetComponent<MeshRenderer>().material.color = Color.green;
    if (Input.GetKeyDown(KeyCode.B)) GetComponent<MeshRenderer>().material.color = Color.blue;
  }
}
