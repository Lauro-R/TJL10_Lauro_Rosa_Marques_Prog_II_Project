using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor;
    protected float peso;//protege o valor mas ainda permite para os filhos

    public virtual void Dropar() //virtual permite editar este método dentro de outra classe que herda o Item.cs
    {
        Debug.Log("Dropei um item");
    }
    
}
