using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{

    public GameObject balaPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //criar uma nova bala
            //saindo da posição atual do player

            Vector3 pos = this.transform.position;

            GameObject novaBala = 
                Instantiate(
                    balaPrefab,//prefab da bala
                    pos,//posicao do player
                    balaPrefab.transform.rotation//rotação original da bala
                    );
        }
    }
}
