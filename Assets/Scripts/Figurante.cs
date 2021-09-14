using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figurante : MonoBehaviour
{

  void Update()
  {
    if(ScriptyPause.pause == false)
    {
      transform.Translate(Vector2.right * 1.5f * Time.deltaTime);
    }
  }

}