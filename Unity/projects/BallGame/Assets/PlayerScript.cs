using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  // Update is called once per frame
  void Update()
  {
    var x = Input.GetAxis("Horizontal");
    transform.Translate(x * 0.2F, 0, 0);
  }
}
