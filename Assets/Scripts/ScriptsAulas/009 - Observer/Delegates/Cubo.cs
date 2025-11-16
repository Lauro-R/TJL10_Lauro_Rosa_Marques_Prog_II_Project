using Unity.VisualScripting;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    float vel = 1;
    private void OnEnable()//sempre que você fazer uma função para adicionar
    {
            
        ObserverManager.Instance.Morrer += AumentarVelocidade;
        UnityEventManager.Instance.Atacar.AddListener(AumentarVelocidade);
        
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * vel);
    }

    private void OnDisable()//você tem que lembrar de fazer uma função para remover quando ele é desabilitado
    {
        ObserverManager.Instance.Morrer -= AumentarVelocidade;
        UnityEventManager.Instance.Atacar.RemoveListener(AumentarVelocidade);
    }

    void Rotacionar()
    {
        transform.Rotate(new Vector3(0, 25f, 0));
    }

    void AumentarVelocidade()
    {
        vel += 0.25f;
    }
}
