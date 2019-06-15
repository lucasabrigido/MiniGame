using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public UiControlador UI;
    public float Velocidade;
    private void Start(){
        UI = GameObject.Find("Canvas").GetComponent<UiControlador>();
        Destroy(gameObject, 5f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Velocidade*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D colisor){
        if(colisor.gameObject.tag == "Player"){
            //colisor.GetComponent<personagem>().Vida-=20;
            UI.Vida.text = (colisor.GetComponent<personagem>().Vida-=20).ToString();
            Destroy(gameObject);
        }
        if(colisor.gameObject.tag == "Barreira"){
            GameObject personagem = GameObject.FindGameObjectWithTag("Player");
            //personagem.GetComponent<personagem>().Pontos+=10;
            UI.Pontos.text = (personagem.GetComponent<personagem>().Pontos+=10).ToString();
            Destroy(gameObject);
    }
}
}
