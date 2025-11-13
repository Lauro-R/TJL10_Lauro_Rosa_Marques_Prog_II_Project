using UnityEngine;

public class EnemyIdle : Status
{
    public EnemyIdle(StateMachine newStateMachine) : base(newStateMachine)
    {
        Debug.Log("Construtor Enemy Idle");
        this.myStateMachine = newStateMachine;
    }

    public override void EnterStatus()
    {
        Debug.Log("Enemy Entering Idle");
        base.EnterStatus();
    }
    public override void ExitStatus()
    {
        Debug.Log("Enemy Exiting Idle");
        myStateMachine.GetComponent<EnemyStateMachine>().EnemyRigidbody.linearVelocity = new Vector3(0, 0, 0);
    }
    public override void UpdateStatus()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myStateMachine.ChangeStatus(new EnemyJumping(myStateMachine));
        }
        Debug.Log("Enemy In Idle");
    }
}
