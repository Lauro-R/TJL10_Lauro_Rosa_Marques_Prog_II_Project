using UnityEngine;

public class EnemyStateMachine : StateMachine
{
    public Rigidbody EnemyRigidbody;
    void Start()
    {
        ChangeStatus(new EnemyIdle(this));//está recebendo a variavel do pai StateMachine
    }
    void Update()
    {
        
    }
}
