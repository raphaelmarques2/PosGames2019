using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    public float minSize = 0.1f;
    public float maxSize = 2.0f;

    public int minPontos = 10;
    public int maxPontos = 1;

    public int pontos;

    void Start()
    {
        float random = Random.Range(0f, 1f);

        float size = Mathf.Lerp(minSize, maxSize, random);
        this.pontos = Mathf.RoundToInt(Mathf.Lerp(minPontos, maxPontos, random));

        this.transform.localScale = new Vector3(size, size, 1);
    }
    
    public string bulletTag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(bulletTag))
        {
            Destroy(this.gameObject);

            //buscando pelo nome (evite isso)
            //Pontuacao p = GameObject.Find("Pontuacao").GetComponent<Pontuacao>();

            //buscando pela tag (faz sentido se tiver vários objetos com a mesma tag)
            //Pontuacao p = GameObject.FindGameObjectWithTag("Tag").GetComponent<Pontuacao>();

            Pomtuacao p = GameObject.FindObjectOfType<Pomtuacao>();

            p.AddPoints(this.pontos);

        }
    }
    


}
