using UnityEngine;

public class Escudo : Item, IDestruir
{
    public float defesa;
    
    public int minLevel;
    
    public string material;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Escudo Defesa" + defesa);
        Debug.Log("Escudo Valor" + valor);
        Debug.Log("Escudo Qualidade" + minLevel);
        Debug.Log("Escudo Peso" + peso);
        Debug.Log("Escudo Material" + material);

        Dropar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destruir()
    {

    }
}
