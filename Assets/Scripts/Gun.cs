using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe cuida da arma.
///Ao clicar o botão, toca o som de tiro e checa se o objeto na direção dela é um zumbi
///, e se for manda o dano pro controlador dele (classe Target)
///</summary>

public class Gun : MonoBehaviour
{
    public float damage = 30f;
    public float range = 100f;
    public Camera fpsCam;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Ele conta o clique esquerdo no play como input...
            //Sera que tem como mudar isso?
            Shot();
        }
    }
    void Shot()
    {
        RaycastHit hit;
        //Toca o audio quando entra no metodo
        audioData.Play(0);
        //Se tiver algum objeto na direcao do raycast dentro do alcance "range"...
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //...escreve o nome do objeto no console, e se ela tiver o script Target,
            //faz o calculo de dano
            //Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            Debug.Log(target.health);
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
