using UnityEngine;

public class Diamante : Item, IDestruir
{
    
    public string qualidade;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valor = 1000;// herdado do Pai : Item
        Debug.Log("Diamante Valor" + valor);
        Debug.Log("Diamante Peso" + peso);
        Debug.Log("Diamante Qualidade" + qualidade);

        Dropar();
    }
    //permite que a classe do Pai seja editável
    public override void Dropar()//com o override, pode acessar o que tem no pai, mas adicionar dentro do Dropar() exclusivamente dentro do Diamante.
    {
        base.Dropar();//ainda acessa o que tem dentro do Dropar contido dentro do Item.cs
        Debug.Log("Muito Dinheiro!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destruir()
    {

    }
}
