using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    PoolGod poolGod;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine("Criar");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {//acessa o singleton e instancia direto em qualquer spawner
            PoolGod.Instance.Spawn(TipoPool.Cubo, this.transform.position, this.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PoolGod.Instance.Spawn(TipoPool.Bola, this.transform.position, this.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            PoolGod.Instance.Spawn(TipoPool.Capsula, this.transform.position, this.transform.rotation);
        }
    }

    //Co rotina
    IEnumerator Criar()
    {
        yield return new WaitForSeconds(0.1f);
        //poolCubos.Spawn(this.transform.position, this.transform.rotation);//acessa a pool do PoolSimples.cs
        StartCoroutine("Criar");
    }
}
