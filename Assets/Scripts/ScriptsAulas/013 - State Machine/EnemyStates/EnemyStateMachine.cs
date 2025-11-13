using UnityEngine;

public class EnemyStateMachine : StateMachine
{
    public Rigidbody EnemyRigidbody;
    void Start()
    {
        ChangeStatus(new EnemyIdle(this));
    }
    void Update()
    {
        
    }
}
