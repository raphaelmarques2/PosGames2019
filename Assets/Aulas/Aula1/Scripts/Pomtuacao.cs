using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pomtuacao : MonoBehaviour
{
    public int pontos;
    
    void Start()
    {
        pontos = 0;
    }

    public void AddPoints(int p)
    {
        pontos += p;
    }
    
}
