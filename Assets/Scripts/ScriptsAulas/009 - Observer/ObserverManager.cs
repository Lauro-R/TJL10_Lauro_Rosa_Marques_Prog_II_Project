using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    public static ObserverManager Instance;//transforma o Observer Manager em um Singleton

    
    public delegate void AllFunctions();//criou o tipo do Delegate
    public delegate void AllCalculations(int a, int b);
    public delegate string AllFalas();

    //public event AllFalas TodasFalas;
    public event AllCalculations Calculos;

    // public AllFunctions minhasFuncoes;//criou o delegate do tipo AllFunctions()
    public AllFunctions Morrer;
    //event encapsula cada acesso do AllFunctions em outras classes impedindo deles igualarem com os outros ou modificar o valor dos outros.
    //ex: public event AllFunctions Morrer; não permitiria modificações nos outros objetos utilizando esse delegate.
    private void Awake()
    {
        Instance = this;
        // minhasFuncoes = MeAnunciar; //está dizendo no start que a função do delegate minhasFuncoes é utilizar o método MeAnunciar
        Morrer += MensagemMorte;
        //TodasFalas += RetornaNome;
        Calculos = FazerSoma;
        ActionManager.Gritar += FazerSoma;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //a interrogação checa se o valor de Morrer existe, se existe ele avança para o .Invoke
                Morrer?.Invoke(); //Invoca o Delegate quando apertar Espaço
            
        }

        /* exemplos de delegate funcionando
        
        if (Input.GetKeyDown(KeyCode.O))
        {
            //+= faz com que o delegate adicione ambas as funções para o minhasFuncoes inves de substituir
            minhasFuncoes += MeAnunciar;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //+= faz com que o delegate adicione ambas as funções para o minhasFuncoes inves de substituir
            minhasFuncoes -= MeAnunciar;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            minhasFuncoes -= DarTchau;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {//remove da pilha
            minhasFuncoes += DarTchau;
        }*/

        if (Input.GetKeyDown(KeyCode.Backspace))
        {//limpa as informações dentro do minhasFuncoes
            //Morrer = null;
        }
    }
    void MensagemMorte()
    {
        Debug.Log("Muoreu");
    }

    void DarTchau()
    {
        Debug.Log("Olá!");
    }

    string RetornaNome()
    {
        return "Lauro";
    }

    void FazerSoma(int num1, int num2)
    {
        Debug.Log(num1+num2);
    }
}
