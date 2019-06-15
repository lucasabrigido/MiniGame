using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObj : MonoBehaviour
{
    public float tempo;
    void Start()
    {
        Destroy(gameObject, tempo);
    }
}
