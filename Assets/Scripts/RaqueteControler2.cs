using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaqueteControler2 : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float minhaVelocidade = 5f;
    public float meuLimite = 3.5f;
    private bool automatico;
    public Transform transformBola;
    private bool setaCima;
    private bool setaBaixo;
    private bool verificaPlayer;

    // Start is called before the first frame update

    void Start()
    {
        minhaPosicao = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float deltaVelocidade = minhaVelocidade * Time.deltaTime;
        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
        setaCima = Input.GetKey(KeyCode.UpArrow);
        setaBaixo = Input.GetKey(KeyCode.DownArrow);

        if (setaCima || setaBaixo)
        {
            verificaPlayer = true;
        }


        if (verificaPlayer)
        {
            if (setaCima)
            {
                meuY = meuY + deltaVelocidade;
            }
            if (setaBaixo)
            {
                meuY = meuY - deltaVelocidade;
            }
        }
        else
        {
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.01f);
        }

        if (meuY < -meuLimite)
        {
            meuY = -meuLimite;
        }
        if (meuY > meuLimite)
        {
            meuY = meuLimite;
        }
    }

}

