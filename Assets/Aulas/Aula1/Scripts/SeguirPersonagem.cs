using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonagem : MonoBehaviour
{

    public Transform target;
    
    void Update()
    {
        //pega posição do target e joga no objeto atual
        Vector3 pos = this.transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;
        this.transform.position = pos;
    }
}
