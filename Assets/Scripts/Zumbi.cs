using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla movimento dos zumbis, e ajustam o número de zumbis ativos quando eles morrem.
///</summary>

public class Zumbi : MonoBehaviour
{
    //public static int NumZumbi;
    public bool morte;
    public GameObject player;
    public static float velocidade = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Salva o main camera,
        //incrementa o numero de zumbis em 1,
        //e imprime o numero atual na tela
        player = GameObject.Find("Main Camera");
        //NumZumbi++;
        //print(NumZumbi);
    }

    // Update is called once per frame
    void Update()
    {
        //Calcula a direcao do player (main camera) e a distancia
        //relativo ao zumbi, e usa a velocidade para move-lo
        //na direcao do player um pouco por vez.
        Vector3 direcao = (player.transform.position - transform.position).normalized;
        float distancia = (player.transform.position - transform.position).magnitude;
        //O Time.deltaTime "sincroniza" o movimento com a renderizacao
        Vector3 move = transform.position + (direcao * velocidade * Time.deltaTime);
        //Com o transform.position atualizado dessa forma, os Zumbis nao se movem pra cima nem pra baixo
        transform.position = new Vector3(move.x, 1f, move.z);

        if(ControleRelogio.tempoRestante % 20 == 0)
        {
            velocidade *= 2;
        }

        //Agora quem checa a colisao e o player
        if(morte)
        {
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
            Destroy(gameObject);
        }
    }
}
