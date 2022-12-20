fusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public GameObject[] hartjes = new GameObject[3];
    public float life;


    void Update()
    {
        if (life < 1)
        {
            Destroy(hartjes[0]);
        }
        else if (life < 2)
        {
            Destroy(hartjes[1]);
        }
        else if (life < 3)
        {
            Destroy(hartjes[2]);
        }
    }
}
