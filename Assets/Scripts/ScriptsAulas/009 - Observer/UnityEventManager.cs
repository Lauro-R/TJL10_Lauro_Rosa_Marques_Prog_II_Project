using UnityEngine;
using UnityEngine.Events; //necessário para criar um unity event no dedo

public class UnityEventManager : MonoBehaviour
{
    #region Singleton
    public static UnityEventManager Instance;


    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public UnityEvent Atacar;

    void Start()
    {
        Atacar.AddListener(Gritar);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Atacar.Invoke();
        }


        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Atacar = null; 
        }
    }

    void Gritar()
    {
        Debug.LogWarning("Atacaaaarrrr");
    }

}
