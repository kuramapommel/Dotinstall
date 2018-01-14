using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoxScript : MonoBehaviour
{

  public Transform ball;

  public int n = 0;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonUp("Jump"))
    {
      Instantiate(ball, transform.position, transform.rotation);
      n++;
    }

    if (n > 10)
    {
      Application.LoadLevel("GameOver");
    }
  }
}
