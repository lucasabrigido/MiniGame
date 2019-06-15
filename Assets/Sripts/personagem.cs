using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class personagem : MonoBehaviour
{
    public float Velocidade;
    public float IncrementoY;
    Vector2 PosAlvo;
    public float Limite;
    public int Vida = 100;
    public int Pontos;
    public UiControlador UiControler;

    // Update is called once per frame
    void Update()
    {
        if(Vida<=0){
            SceneManager.LoadScene(0);
            //UiControler.GameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, PosAlvo, Velocidade*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow)){
           // Debug.Log("entrou no if");
            if((transform.position.y - IncrementoY) >= -Limite){
               //  Debug.Log("entrou no if do if");
                PosAlvo = new Vector2(transform.position.x, transform.position.y - IncrementoY);
            }
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
           // Debug.Log("entrou no elseif");
            if((transform.position.y + IncrementoY) <= Limite){
                 //Debug.Log("entrou no if do elseif");
                PosAlvo = new Vector2(transform.position.x, transform.position.y + IncrementoY);
            }
        }
   
   
    }
}
