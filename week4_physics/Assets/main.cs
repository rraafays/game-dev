using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
  public GameObject block_prefab;
  public float thrust_strength;
  public float spawn_frequency;
  private float spawn_countdown;
  private GameObject current_block;

  void Start()
  {
    Debug.Assert(block_prefab != null);
  }

  void Update()
  {
    spawn_countdown -= Time.deltaTime;

    if (spawn_countdown <= 0)
    {
      spawn_countdown += spawn_frequency;

      var position = new Vector3(Random.Range(-3.0f, 3.0f), 8, 0);
      var size     = new Vector3(Random.Range(0.5f, 3.0f), Random.Range(0.9f, 1.1f), 1);

      current_block = Instantiate(block_prefab, position, Quaternion.identity);
      current_block.transform.localScale = size;

      current_block.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(size.x, size.y);

      current_block.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }

    var rb = current_block.GetComponent<Rigidbody>();
    if (Input.GetKeyDown(KeyCode.A)) rb.AddForce(Vector3.left  * thrust_strength);
    if (Input.GetKeyDown(KeyCode.D)) rb.AddForce(Vector3.right * thrust_strength);
  }
}
