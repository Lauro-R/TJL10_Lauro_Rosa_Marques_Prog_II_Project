using UnityEngine;

public abstract class Status
{
    protected StateMachine myStateMachine;

    //Construtor para os Status

    public Status(StateMachine newStateMachine)
    {
        Debug.Log("Construtor Status");
        this.myStateMachine = newStateMachine;
    }
    public virtual void EnterStatus() 
    { 
    
    }

    public virtual void UpdateStatus() 
    { 
    
    }

    public virtual void ExitStatus() 
    { 
    
    }
}
