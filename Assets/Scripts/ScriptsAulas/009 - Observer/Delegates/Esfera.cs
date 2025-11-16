using UnityEngine;

public class Esfera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()//sempre que você fazer uma função para adicionar
    {
        ObserverManager.Instance.Morrer += Crescer;
        ActionManager.Falar += Crescer;
    }
    private void OnDisable()//você tem que lembrar de fazer uma função para remover
    {
        ObserverManager.Instance.Morrer -= Crescer;
    }

    void Crescer()
    {
        transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
    }
    public void FuncaoLegal()
    {

    }

}
