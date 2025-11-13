using UnityEngine;

public class Loja : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Comprar(GameObject objeto)
    {
        if (objeto.gameObject.GetComponent<Item>()) //devido a Herança, todos os itens automaticamente atualizam para o get component listado, pegando o valor em baixo
        {
            return objeto.gameObject.GetComponent<Item>().valor;
        }
        return 0;
    }
}
