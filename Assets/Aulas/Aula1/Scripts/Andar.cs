using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        //-1 esquerda
        //0 parado
        //1 direita
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Rigidbody2D r = GetComponent<Rigidbody2D>();
        
        Vector2 vel = r.velocity;
        vel.x = h * speed;
        r.velocity = vel;
        
    }
}
