using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolGod : MonoBehaviour
{

    public static PoolGod Instance;

    //estrutura de todas as Pools
    [System.Serializable]
    public class Pools//subclasse dentro do PoolGod
    {
        public TipoPool poolName;//cada pull conterá essas informações para
        public GameObject elemento;
        public int poolSize;
        public Transform parent;
    }

    [SerializeField]
    List<Pools> tiposPools;//Lista que aparece no Pool God dentro da unity

    Dictionary<TipoPool, Queue<GameObject>> poolDictionary;//Dicionario para salvar as pools

    private void Awake()
    {
        if (Instance != null && Instance != this)//Singleton
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
            PrepararPools();
    }

    void PrepararPools()
    {
        poolDictionary = new Dictionary<TipoPool, Queue<GameObject>>();//cria o dicionario dentro do Método PrepararPools

        foreach (Pools poolAtualDoForEach in tiposPools)
            //pega a Pools escolhida e coloca ela dentro da variavel poolAtualdoForEach pra cada elemento da lista e separa ele pra trabalhar no for
        {
            Queue<GameObject> filaTemp = new Queue<GameObject>();
            for (int i = 0; i < poolAtualDoForEach.poolSize; i++)
            {
                GameObject objTemp = Instantiate(poolAtualDoForEach.elemento);
                objTemp.transform.SetParent(poolAtualDoForEach.parent);//organiza o Pool dentro dos empties pra organização
                objTemp.SetActive(false);
                filaTemp.Enqueue(objTemp);
            }
            poolDictionary.Add(poolAtualDoForEach.poolName, filaTemp);
        }
    }
    public void Spawn(TipoPool poolName, Vector3 newPosition, Quaternion newsRotation)
    {
        GameObject objTemp;//escolhe qual pool do dicionario
        objTemp = poolDictionary[poolName].Dequeue();//remove o objeto temporario da queue
        objTemp.SetActive(true);
        objTemp.transform.position = newPosition;
        objTemp.transform.rotation = newsRotation;

        poolDictionary[poolName].Enqueue(objTemp);//adiciona ele na queue novamente.
    }
}

public enum TipoPool { Cubo, Bola, Capsula };
