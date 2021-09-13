using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
//Bibliotecas               Kenedy você alterou sem querer

public class Restart : MonoBehaviour {  //Declaração da Classe
  
   void Update () {
     if(Input.GetButtonDown("Restart"))
     {
         SceneManager.LoadScene("Intro");
     }
     
   }
 

}



             
