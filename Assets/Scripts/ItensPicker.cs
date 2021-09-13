using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Bibliotecas
public class ItensPicker : MonoBehaviour { // Nome da Classe

    

    private int Itens; //Conta o numero de moedas
    public Text scoreText; //Pontuação
     public Text liveText; // Vida
    private int live; // barra de vida
    public Image healthbar; // Imagem da barra de vida

    public AudioSource ItensSound; // Som de pegar a  Moeda
    public AudioSource lifeSound; // Som da morte

    public AudioSource faseSound; // Som da Mudança de fase
    private bool imunidade;
    private long tempo_de_imunidade;
    
    private void Start()
    {
        //inicializa variaveis 
        Itens = ScriptController.userPoints;
        scoreText.text = "";
        liveText.text = "";
        live = ScriptController.userLife;
        
      
    }

    private void Update()
    {
        if(live == 0)
        {
            SceneManager.LoadScene("Game_Over");
        }
        if(imunidade == true)
        {
            tempo_de_imunidade--;
            if(tempo_de_imunidade == 0)
            {
                imunidade = false;
            }
        }
        scoreText.text = "Itens: "+Itens.ToString();
        liveText.text = "Life: "+live.ToString();
        UpdateHealthBar();
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Item") == true) //Essa condição verifica se o player encostou com um objeto com rotulo Coin
          {
              ItensSound.Play(); //som de pegar moeda
              //GetComponent<AudioSource>().Play();  
              Itens += 1; // Incrementa contador
              Destroy(collision.gameObject); //Peguei a moeda destroi a moeda
              ScriptController.userPoints=Itens;
          }
          if(collision.CompareTag("Inimigo") == true)//Essa condição verifica se o player encostou com um objeto com rotulo Fire
          {
              lifeSound.Play(); //Som de dor
              //GetComponent<AudioSource>().Play();  
              live -= 1; //Decrementa a vida
              Destroy(collision.gameObject); //Destroi o fogo
              ScriptController.userLife=live;
              ScriptController.carregaHistoria();
          }
          if(collision.CompareTag("Figurante") == true)//Essa condição verifica se o player encostou com um objeto com rotulo Fire
          {
              //GetComponent<AudioSource>().Play();  
              if(imunidade == false)
              {  
                lifeSound.Play(); //Som de dor
                live -= 1; //Decrementa a vida
                imunidade = true;
                tempo_de_imunidade = 60;
              }
              ScriptController.userLife=live;
              ScriptController.carregaHistoria();
          }
          if(collision.CompareTag("Fase") == true)
          {
             faseSound.Play();
              //SceneManager.LoadScene("fase2");
              //ScriptController.userPoints=coin;
              //ScriptController.userLife=life;
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
              
          }
    }
    private void UpdateHealthBar()
    {
        healthbar.fillAmount = live/10;
    }
    


}