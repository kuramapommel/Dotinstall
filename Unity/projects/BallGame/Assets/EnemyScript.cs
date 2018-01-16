using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{

  // Update is called once per frame
  void Update()
  {
    transform.Translate(0, 0, -0.1f, Space.World);
    transform.Rotate(1, 1, 1);

    if (transform.position.z < -12.0f)
    {
      SceneManager.LoadScene("GameOver");
    }
  }

  void OnCollisionEnter()
  {
    Destroy(gameObject);
  }
}
