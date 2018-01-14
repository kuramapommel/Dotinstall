using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public int x = 5;
  // Use this for initialization
  void Start()
  {
    Debug.Log("Hello world -> " + x);
  }

  // Update is called once per frame
  void Update()
  {
    // transform.position += new Vector3(0, 0, 1);
    transform.Translate(0, 0, 1);
  }
}
