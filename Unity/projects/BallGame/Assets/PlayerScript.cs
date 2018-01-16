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

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "Enemy(Clone)")
    {
      var localScale = transform.localScale;
      var x = localScale.x - Random.Range(0.1F, 0.5F);

      localScale.x = x < 1.0f ? 1.0f : x;
      transform.localScale = localScale;
    }

  }
}
