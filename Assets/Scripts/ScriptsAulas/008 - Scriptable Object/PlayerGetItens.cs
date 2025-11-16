using UnityEngine;

public class PlayerGetItens : MonoBehaviour
{
    private int itemCount, item2Count, item3Count;

    public int ItensColetados //propriedade para mostrar os contadores 
    {
        get
        {
            return itemCount + item2Count + item3Count;
        }
    }

    public int Pontuacao //propriedade que retorna os valores da pontuacao
    {
        get 
        {
            return (itemCount*10) + (-item2Count * 15) + (item3Count * 50); //adiciona valores nas variaveis que modificam o placar sem deixa-las acessiveis
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        float dirX, dirZ;
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().linearVelocity = new Vector3(dirX, 0, dirZ) * 10f;
        //Colisão estava bugada com este metodo de movimentação
        //transform.Translate(new Vector3(dirX, 0, dirZ) * 10f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)//colisão para o contador e destruidor dos itens
    {
        if(collision.gameObject.tag == "Item 1")
        {
            itemCount++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Item 2")
        {
            item2Count++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Item 3")
        {
            item3Count++;
            Destroy(collision.gameObject);
        }
    }
}
