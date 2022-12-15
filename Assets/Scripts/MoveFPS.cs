using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla o movimento do player
///</summary>

public class MoveFPS : MonoBehaviour
{
    public static float velocidade = 0.1f;
    // Update is called once per frame
    void Update()
    {
        //Acumula a posicao da camera na direcao desejada.
        //Mas como usa transform.forward e transform.right,
        //a direcao do movimento muda dependendo de para onde a camera esta olhando.

        //Peguei somente os componentes x e z para impedir que o jogador "flutue".
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(transform.forward.x * velocidade, 0f, transform.forward.z * velocidade);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(transform.forward.x * velocidade, 0f, transform.forward.z * velocidade);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(transform.right.x * velocidade, 0f, transform.right.z * velocidade);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(transform.right.x * velocidade, 0f, transform.right.z * velocidade);
        }
    }
}
