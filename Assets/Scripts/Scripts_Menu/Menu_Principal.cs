
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Principal : MonoBehaviour
{
   [SerializeField] private string nomeDoLevelDeJogo;
   [SerializeField] private GameObject painelMenuInicial;
   [SerializeField] private GameObject painelOpcoes;
   [SerializeField] private GameObject painelCredits;
   
   public void jogar(){

    SceneManager.LoadScene(nomeDoLevelDeJogo);

   }

   public void abrirOpcoes(){
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
   }

   public void fecharOpcoes(){
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
   }

   public void abrirCreditos() 
   {
    painelMenuInicial.SetActive(false);
    painelOpcoes.SetActive(false);
    painelCredits.SetActive(true);
   }

  public void fecharCreditos()
{
    painelCredits.SetActive(false);
    painelOpcoes.SetActive(true);
  }

    public void sairDoJogo() {
        Debug.Log("Sai");
        Application.Quit();
    }

}


