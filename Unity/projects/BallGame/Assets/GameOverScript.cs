using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
  public GUIStyle style;

  // Use this for initialization
  void OnGUI()
  {
    GUI.Label(new Rect(10, 10, 100, 30), "Game Over...", style);
  }
}
