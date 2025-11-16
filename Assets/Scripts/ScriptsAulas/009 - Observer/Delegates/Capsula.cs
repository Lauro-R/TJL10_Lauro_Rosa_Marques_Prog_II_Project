using UnityEngine;

public class Capsula : MonoBehaviour
{
    private void OnEnable()//sempre que você fazer uma função para adicionar
    {

        ObserverManager.Instance.Morrer += MudarCor;
    }

    private void OnDisable()//você tem que lembrar de fazer uma função para remover quando ele é desabilitado
    {
        ObserverManager.Instance.Morrer -= MudarCor;
    }

    private void Start()
    {
        
    }
        void MudarCor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
