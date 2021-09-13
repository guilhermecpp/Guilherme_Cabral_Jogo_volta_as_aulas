using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
//Bibliotecas               Kenedy você alterou sem querer

public class MostrarScore : MonoBehaviour {  //Declaração da Classe
  

  public Text score;
  void Start()
  {
      score.text = "Score: "+ ScriptController.userPoints;
  }
 

}



             
