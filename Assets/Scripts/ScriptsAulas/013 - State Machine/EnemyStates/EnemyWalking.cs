using UnityEngine;

public class EnemyWalking : Status
{
    public EnemyWalking(StateMachine newStateMachine) : base(newStateMachine)
    {

    }
    public override void EnterStatus()
    {
        Debug.Log("Enemy Entering Walk");
    }
    public override void ExitStatus()
    {
        Debug.Log("Enemy Exiting Walk");
    }
    public override void UpdateStatus()
    {
        Debug.Log("Enemy In Walk");
    }
}
