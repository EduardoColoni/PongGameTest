using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float minhaVelocidade = 5f;
    public float meuLimite = 3.5f;
    public Transform transformBola;

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

        if (Input.GetKey(KeyCode.W))
        {
            meuY = meuY + deltaVelocidade;
        }
        if (Input.GetKey(KeyCode.S))
        {
            meuY = meuY - deltaVelocidade;
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
