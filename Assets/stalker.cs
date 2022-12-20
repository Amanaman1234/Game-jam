using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalker : MonoBehaviour
{

    public float snelheid = 2f;
    public Transform player;
    public float y = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPos = new Vector3(player.position.x, player.position.y + y, -10);
        transform.position = Vector3.Slerp(transform.position, NewPos, snelheid * Time.deltaTime);
        
    }
}
