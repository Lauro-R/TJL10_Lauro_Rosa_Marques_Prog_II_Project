using UnityEngine;

public class PlayerStates : StateMachine
{
    bool trocandoStatus;

    [SerializeField]
    private Renderer objectRenderer;


    PlayerStatus status;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeStatus(PlayerStatus.Jumping);
        }
        if (trocandoStatus == false)
        {
            UpdateStatus();
        }
        
    }

    public void ChangeStatus(PlayerStatus newStatus)
    {
        //Metodo que Troca entre os States da State Machine, Ele facilita os outros states a trocarem.
        trocandoStatus = true;//booleana que diz se está trocando de state machine
        ExitStatus(status);//sai do estado que estava anteriormente.

        EnterStatus(newStatus);//entra em um estado novo

        status = newStatus;//novo estado da statemachine.

        trocandoStatus = false;
    }
    void EnterStatus(PlayerStatus newStatus)
    {
        switch (newStatus)
        {
            case PlayerStatus.Walking:
                UpdateWalking();
                break;

            case PlayerStatus.Jumping:
                UpdateJumping(); 
                break;
        }
    }

    
    void ExitStatus(PlayerStatus oldStatus)
    {
        switch(oldStatus)
        {
            case PlayerStatus.Walking:
                UpdateWalking();
                break;

            case PlayerStatus.Jumping:
                UpdateJumping();
                break;
            case PlayerStatus.Frozen:
                UpdateFrozen();
                break;
            case PlayerStatus.Paralyzed:
                UpdateParalyzed();
                break;
            case PlayerStatus.Normal:
                UpdateNormal();
                break;
            case PlayerStatus.Sleep:
                UpdateSleep();
                break;
        }
    }
    void UpdateStatus()
    {
        switch (status)
        {
            case PlayerStatus.Idle:
                UpdateIdle();
                break;
            case PlayerStatus.Walking:
                UpdateWalking();
                break;
            case PlayerStatus.Jumping:
                UpdateJumping();
                break;
            case PlayerStatus.Frozen:
                UpdateFrozen();
                break;
            case PlayerStatus.Paralyzed:
                UpdateParalyzed();
                break;
            case PlayerStatus.Normal:
                UpdateNormal();
                break;
            case PlayerStatus.Sleep:
                UpdateSleep();
                break;
        }
    }
    void UpdateIdle()
    {
        Debug.Log("State: Idle");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeStatus(PlayerStatus.Jumping);
        }
    }
    void UpdateWalking()
    {
        Debug.Log("State: Walking");
        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }
    }
    void UpdateJumping()
    {
        Debug.Log("State: Jumping");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeStatus(PlayerStatus.Jumping);
        }
    }
    void UpdateFrozen()
    {
        Debug.Log("State: Frozen");
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            ChangeStatus(PlayerStatus.Frozen);
        objectRenderer.material.color = Color.blue;
        }
    }
    void UpdateParalyzed()
    {
        Debug.Log("State: Paralyzed");
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeStatus(PlayerStatus.Frozen);
            objectRenderer.material.color = Color.yellow;
        }

    }
    void UpdateNormal()
    {
        Debug.Log("State: Normal");
    }
    void UpdateSleep()
    {
        Debug.Log("State: Sleep");
    }
}
public enum PlayerStatus { Idle, Walking, Jumping, Frozen, Paralyzed, Normal, Sleep };
//Enumerator que permite os estados que a State Machine vai utilizar

