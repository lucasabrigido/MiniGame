using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public float Velocidade;
    public float ValorXInicial;
    public float ValorXFinal;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Velocidade*Time.deltaTime);
        if (transform.position.x<= ValorXFinal){
            Vector2 pos = new Vector2(ValorXInicial,transform.position.y);
            transform.position = pos;
        }
    }
}
