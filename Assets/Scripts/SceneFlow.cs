using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneFlow : MonoBehaviour
{
   // BUILD INDEX:
   // * 0: Main Menu
   // * 1: Movement
   // * 2: Options
   // * 3: Animations
   public void ChangeScene(int sceneIndex)
   {
      SceneManager.LoadScene(sceneIndex);
   }
}
