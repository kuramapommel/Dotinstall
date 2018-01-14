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
      localScale.x -= Random.Range(0.1F, 0.5F);

      if (localScale.x < 1.0F)
      {
        localScale.x = 1.0F;
      }

      transform.localScale = localScale;
    }

  }
}
