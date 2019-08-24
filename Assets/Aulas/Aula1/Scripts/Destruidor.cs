using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//se destroi depois de algum tempo
public class Destruidor : MonoBehaviour
{

    public float time;

    void Start()
    {
        Invoke("AutoDestroy", time);
    }
    
    void AutoDestroy()
    {
        Destroy(this.gameObject);
    }

}
