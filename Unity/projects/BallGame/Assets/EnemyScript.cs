﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

  // Update is called once per frame
  void Update()
  {
    var pos = transform.position;
    pos.z -= 0.1F;
    transform.position = pos;

    transform.Rotate(1, 1, 1);
  }

  void OnCollisionEnter()
  {
    Destroy(gameObject);
  }
}
