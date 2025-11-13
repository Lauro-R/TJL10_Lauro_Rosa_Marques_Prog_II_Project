using UnityEngine;

public class Potion : Item
{
    public float qtdCura;
    
    public string raridade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valor = 10;
        Debug.Log("Potion Defesa" + qtdCura);
        Debug.Log("Potion Valor" + valor);
        Debug.Log("Potion Peso" + peso);
        Debug.Log("Potion Material" + raridade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
