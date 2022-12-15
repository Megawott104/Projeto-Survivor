using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe gerencia as colisões do jogador, e seta a vida máxima dele.
///</summary>

public class ControlePlayer : MonoBehaviour
{
    private Rigidbody cr;
    Zumbi zumbi;
    //public static int vidaPlayer;

    // Start is called before the first frame update
    void Start()
    {
        cr = GetComponent<Rigidbody>();
        ControleVida.vidaPlayer = 100;
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
    }*/

    void OnTriggerEnter(Collider outro)
    {//Quando encosta em um Zumbi, faz o calculo de dano e destroi o zumbi que encostou
        if (outro.gameObject.CompareTag("Norte") || outro.gameObject.CompareTag("Leste") || outro.gameObject.CompareTag("Oeste"))
        {
            ControleVida.DanoPlayer(20);
            zumbi = outro.GetComponent<Zumbi>();
            zumbi.morte = true;
            //target.Die();
        }
        //gameObject.SetActive(false);//a esfera some
    }
}
