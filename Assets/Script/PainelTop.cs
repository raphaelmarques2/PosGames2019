using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelTop : MonoBehaviour
{

    public Text userName;

    public int score;

    public Transform alien;

    void Start()
    {
        userName.text = "Raphael Marques";
    }

    
    void Update()
    {

        //Input.GetTouch //NAO USE ESSA API

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    score++;
        //    userName.text = "Coins: " + score.ToString();
        //}
    }

    public void Botao1()
    {
        userName.text = "Cliquei no 1";
        alien.Translate(-1, 0, 0);//esquerda
    }
    public void Botao2()
    {
        userName.text = "Cliquei no 2";
        alien.Translate(1, 0, 0);//direita
    }

}
