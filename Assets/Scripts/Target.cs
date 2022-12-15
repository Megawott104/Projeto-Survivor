using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla a quantidade de vida do zumbi e faz o cálculo de dano dele.
///</summary>

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        //Reduz a vida pela quantidade passada em "amount", e se a vida acabar,
        //executa o metodo Die(), que destroi o objeto.
        health -= amount;
        if(health <=0f)
        {
            Die();
        }
    }

    void Die()
    {
        //Modifiquei o Die() para decrementar o NumZumbi quando um morre por causa da arma.
        //Caso contrario, ele fica parado com o valor 4 se o player matar todos os zumbis.
        if(CompareTag("Norte"))
        {
            GeraZumbis.NumZumbiAtivosNorte--;
        }
        else if(CompareTag("Leste"))
        {
            GeraZumbis.NumZumbiAtivosLeste--;
        }
        else if(CompareTag("Oeste"))
        {
            GeraZumbis.NumZumbiAtivosOeste--;
        }
        ControlePlacar.zumbisMortos++;
        Destroy(gameObject);
    }
}
