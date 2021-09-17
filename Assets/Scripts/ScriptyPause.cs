using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;
//Bibliotecas
public class ScriptyPause : MonoBehaviour { // Nome da Classe
   
    public static bool pause = false;
    private void Update()
    {
        if(Input.GetButtonDown("Pausebutton"))
        {
            if(pause == false)
            {
                transform.Translate(Vector2.right * 1500f);
            }else
            {
                transform.Translate(Vector2.right * -1500f);
            }
            pause = !pause;
        }
    }

}