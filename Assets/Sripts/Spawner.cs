using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] inimigo;
    public float TempoInicialSpawn;
    public float TempoSubtrair;
    public float TempoMin;
    float TempoSpawn;

    // Update is called once per frame
    void Update()
    {
        if(TempoSpawn <=0){
            int rand = Random.Range(0,7);
            Instantiate(inimigo[rand], transform.position, Quaternion.identity);
            TempoSpawn = TempoInicialSpawn;
            if(TempoInicialSpawn <= TempoMin){
                TempoInicialSpawn -= TempoSubtrair;
            }
        } else {
            TempoSpawn -= Time.deltaTime;

        }
        
    }
}
