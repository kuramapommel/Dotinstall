using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public int x = 5;
  // Use this for initialization
  void Start()
  {
    // Debug.Log("Hello world -> " + x);
  }

  // Update is called once per frame
  void Update()
  {
    // transform.position += new Vector3(0, 0, 1);
    // transform.Translate(0, 0, 1);

    if (Input.GetButtonUp("Jump"))
    {
      Debug.Log("Jumped!");
    }

    var x = Input.GetAxis("Horizontal");
    transform.Translate(x * 0.2F, 0, 0);
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "RightWall")
    {
      Debug.Log("Hit R!");
    }
  }
}
