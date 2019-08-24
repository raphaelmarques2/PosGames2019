using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pular : MonoBehaviour
{

    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody2D r = GetComponent<Rigidbody2D>();
            r.velocity = new Vector2(0, speed);
        }
    }
}
