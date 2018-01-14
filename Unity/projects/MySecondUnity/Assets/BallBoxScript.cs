using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoxScript : MonoBehaviour
{

  public Transform ball;

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
    }
  }
}
