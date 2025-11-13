using UnityEngine;

public class EnemyJumping : Status
{
    public EnemyJumping(StateMachine newStateMachine): base(newStateMachine)
    {
        
    }
    public override void EnterStatus()
    {
        Debug.Log("Enemy Entering Jump");
        myStateMachine.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100f, 0));
    }
    public override void ExitStatus()
    {
        Debug.Log("Enemy Exiting Jump");
    }
    public override void UpdateStatus()
    {
        Debug.Log("Enemy In Jump");
    }
}
