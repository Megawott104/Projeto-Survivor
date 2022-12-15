using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe cria os zumbis ao longo do jogo.
///Cada base cria um zumbi diferente, e acompanha quantos zumbis de sua base estão na cena
///e quantos foram gerados. Depois que 30 zumbis forem gerados de uma base, ela não criará mais nenhum.
///</summary>

public class GeraZumbis : MonoBehaviour
{

    public static int NumZumbiTotalNorte = 0;
    public static int NumZumbiTotalLeste = 0;
    public static int NumZumbiTotalOeste = 0;
    public static int NumZumbiAtivosNorte = 0;
    public static int NumZumbiAtivosLeste = 0;
    public static int NumZumbiAtivosOeste = 0;
    public GameObject ZumbiPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Enquanto o jogo não acaba, se a base produziu menos de 30 zumbis e
        //se houver menos de 3 zumbis ativos, gera mais um.
        if(ControleJogo.stageClear == 0)
        {
            if(NumZumbiTotalNorte < 30)
           {
                if(NumZumbiAtivosNorte < 3)
                {
                    if(ZumbiPrefab.CompareTag("Norte"))
                    {
                        //O comando a seguir cria novas copias do ZumbiPrefab,
                        //chamando-as de "ZumbiClone", em posicoes aleatorias
                        //entre x = -2 e x = 2, mas com as componentes y e z identicas
                        GameObject ZumbiClone = (GameObject)Instantiate(ZumbiPrefab,
                            transform.position + new Vector3((float) Random.Range(-2,2),0.5f,0f), transform.rotation);

                        NumZumbiAtivosNorte++;
                        NumZumbiTotalNorte++;
                    }
                }

            }
            //Enquanto o jogo não acaba, se a base produziu menos de 30 zumbis e
        //se houver menos de 3 zumbis ativos, gera mais um.

            if(NumZumbiTotalLeste < 30)
            {
                if(NumZumbiAtivosLeste < 3)
                {
                    if(ZumbiPrefab.CompareTag("Leste"))
                    {
                        //O comando a seguir cria novas copias do ZumbiPrefab,
                        //chamando-as de "ZumbiClone", em posicoes aleatorias
                        //entre x = -2 e x = 2, mas com as componentes y e z identicas
                        GameObject ZumbiClone = (GameObject)Instantiate(ZumbiPrefab,
                            transform.position + new Vector3((float) Random.Range(-2,2),0.5f,0f), transform.rotation);

                        NumZumbiAtivosLeste++;
                        NumZumbiTotalLeste++;
                    }
                }

            }
            //Enquanto o jogo não acaba, se a base produziu menos de 30 zumbis e
        //se houver menos de 3 zumbis ativos, gera mais um.

            if(NumZumbiTotalOeste < 30)
            {
                if(NumZumbiAtivosOeste < 3)
                {
                    if(ZumbiPrefab.CompareTag("Oeste"))
                    {
                        //O comando a seguir cria novas copias do ZumbiPrefab,
                        //chamando-as de "ZumbiClone", em posicoes aleatorias
                        //entre x = -2 e x = 2, mas com as componentes y e z identicas
                        GameObject ZumbiClone = (GameObject)Instantiate(ZumbiPrefab,
                            transform.position + new Vector3((float) Random.Range(-2,2),0.5f,0f), transform.rotation);

                        NumZumbiAtivosOeste++;
                        NumZumbiTotalOeste++;
                    }
                }

            }
        }
        
    }
}
