using UnityEngine;

public class Collectable : MonoBehaviour
{
    public SO_Coletavel minhaData;

    private void Start()
    {
        GetComponent<Renderer>().material.color = minhaData.cor;
    }//Faz os coletáveis acessarem a informação de cor dentro do Scriptable object pelo acesso do minhaData.cor

}
