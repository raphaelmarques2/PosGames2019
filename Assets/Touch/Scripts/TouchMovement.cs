using GameBooster;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Velocity2D))]
public class TouchMovement : MonoBehaviour
{
    //se cada direção está pressionada
    public bool left { get; set; }
    public bool right { get; set; }
    public bool up { get; set; }
    public bool down { get; set; }
    
    //velocidade desejada
    public Vector2 speed = new Vector2(5, 5);

    //componente Velocity2D
    Velocity2D vel;

    void Start()
    {
        vel = GetComponent<Velocity2D>();
    }
    
    void Update()
    {
        Vector2 input = new Vector2();

        //converte left|right em -1,0,1
        if (left && !right) input.x = -1;
        if (!left && right) input.x = 1;

        //converte down|up em -1,0,1
        if (down && !up) input.y = -1;
        if (!down && up) input.y = 1;

        //passa os valores pro Velocity
        vel.velocityX = speed.x * input.x;
        vel.velocityY = speed.y * input.y;
    }
}
