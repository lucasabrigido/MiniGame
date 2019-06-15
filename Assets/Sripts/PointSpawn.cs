using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    public GameObject inimigo;
    // Start is called before the first frame update
    void Start()
    {
      Instantiate(inimigo, transform.position, Quaternion.identity);  
      Destroy(gameObject, 2f);
    }

}
