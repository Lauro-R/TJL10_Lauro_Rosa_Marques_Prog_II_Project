using UnityEngine;

public class StateMachine : MonoBehaviour
{
    Status meuStatus;
    

    // Update is called once per frame
    void Update()
    {
        //Indepentende de qual status que for, ele vai chamar o updateStatus
        if (meuStatus != null) 
        {
            meuStatus.UpdateStatus();
        }
    }

    public void ChangeStatus(Status newStatus)
    {
        //if que faz o estado mudar, chamando a saida do estado anterior
        if (meuStatus != null)
        {
            meuStatus.ExitStatus();
        }
        newStatus.EnterStatus();//entra no novo estado

        meuStatus = newStatus;

    }
}
