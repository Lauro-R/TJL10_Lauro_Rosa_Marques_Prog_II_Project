using UnityEngine;
using System.Collections.Generic;

public class PoolSimples : MonoBehaviour
{
    //to do: fazer o pooling ser um singleton
    [SerializeField]
    GameObject elemento;

    [SerializeField]
    int poolSize;//inteiro para manipular o loop do For

    [SerializeField]
    Transform parent;

    Queue<GameObject> minhaPool;

    private void Awake()
    {
        PrepararPool();
    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    // Update is called once per frame
    void PrepararPool()
    {
        minhaPool = new Queue<GameObject>();

        for(int i = 0;i <poolSize; i++)//o for utiliza o inteiro dentro dele para executar o codigo o total de vezes listado ao lado no i < "x" até der todos os loops.
        {
            
            GameObject objetoTemp;//criando objeto temporário dentro do método faz com que ele só ocupe espaço na memoria enquanto está executando  o método
            objetoTemp = Instantiate(elemento);
            objetoTemp.transform.SetParent(parent);//coloca a pool num parent pra ter controle de onde ele spawna na hierarquia pra evitar poluir a cena
            objetoTemp.SetActive(false);
            minhaPool.Enqueue(objetoTemp);
        }
    }
    public void SpawnElemento(Vector3 newPosition, Quaternion newsRotation)
    {
        GameObject objetoTemp = minhaPool.Dequeue(); //pega o primeiro elemento da pilha e remove ele da queue
        objetoTemp.SetActive(true);
        objetoTemp.transform.position = newPosition;
        objetoTemp.transform.rotation = newsRotation;

        minhaPool.Enqueue(objetoTemp);//adiciona o objeto na fila novamente
    }
}
