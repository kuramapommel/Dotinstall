﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  // Update is called once per frame
  void Update()
  {
    transform.Translate(Input.GetAxis("Horizontal") * 0.2F, 0, 0);
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "Enemy(Clone)")
    {
      var x = transform.localScale.x - Random.Range(0.1F, 0.5F);
      transform.localScale = new Vector3(x < 1.0f ? 1.0f : x, 1.0f, 1.0f);
    }
  }
}
