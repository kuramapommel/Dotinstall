using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
  public Transform enemy;

  // Update is called once per frame
  void Update()
  {
    if (Time.frameCount % 60 == 0)
    {
      Instantiate(enemy, new Vector3(Random.Range(-5.0F, 5.0F), 1, 8), transform.rotation);
    }

  }
}
