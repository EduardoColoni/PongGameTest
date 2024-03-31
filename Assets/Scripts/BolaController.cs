using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;
    public float velocidade = -5f;
    private float meuLimite = 12f;
    public AudioClip boing;
    public Transform minhaCamera;
    public Vector3 minhaPosicao;
    private float meuY;
    private float meuX;
    public float delay = 2f;
    public bool jogoIniciado = false;

    // Start is called before the first frame update
    void Start()
    {
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        minhaPosicao.y = meuY;
        minhaPosicao.x = meuX;
        //Iniciando a bola com delay

        //Diminuin o meu valor do delay
        delay = delay - Time.deltaTime;

        //Checando se o valor do delay chegou a 0

        if (delay <= 0 && jogoIniciado == false)
        {
            jogoIniciado = true;

            //Iniciando o jogo
            int direcao = 0;
            direcao = Random.Range(0, 4);
            Debug.Log(direcao);
            if (direcao == 0)
            {
                minhaVelocidade.y = velocidade;
                minhaVelocidade.x = velocidade;
            }
            else if (direcao == 1)
            {
                minhaVelocidade.y = -velocidade;
                minhaVelocidade.x = velocidade;
            }
            else if (direcao == 2)
            {
                minhaVelocidade.y = velocidade;
                minhaVelocidade.x = -velocidade;
            }
            else
            {
                minhaVelocidade.y = -velocidade;
                minhaVelocidade.x = -velocidade;
            }

            meuRB.velocity = minhaVelocidade;
        }

        if (transform.position.x > meuLimite || transform.position.x < -meuLimite)
        {
            meuX = 0;
            meuY = 0;
            transform.position = new Vector3(meuX, meuY); // Definindo a posição da bola como (0, 0, z)
            //SceneManager.LoadScene(1);
        }


    }

    //Criando meu evento de colisão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(boing, minhaCamera.position);
    }
}
