using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
//Bibliotecas               Kenedy você alterou sem querer

public class Enter : MonoBehaviour {  //Declaração da Classe
  
   public void Start()
   {
     ScriptController.userLife = 10;
     ScriptController.userPoints = 0;
   }
   public void Update () {
     if(Input.GetButtonDown("Enter"))
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
     }
     
   }
 

}



             
