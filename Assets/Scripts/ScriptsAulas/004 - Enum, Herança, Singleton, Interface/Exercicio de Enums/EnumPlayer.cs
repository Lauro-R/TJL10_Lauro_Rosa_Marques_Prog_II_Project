using UnityEditor.PackageManager;
using UnityEngine;



public class EnumPlayer : MonoBehaviour, IDestruir, IDamagge //acesso as interfaces dentro da classe
{
    //É necessario criar a tipagem do enumerator para poder começar um Enumerator, executada no metodo abaixo


    public statusEffects playerStatus;
    public string nome;
    public int vida;
    public int atk;
    public int def;

    public Directions dirPlayer;
    //acessa o enumerator Directions

    [SerializeField]
    private Renderer objectRenderer;
    //cria um acesso ao renderer de cor de um objeto pelo serialize field permitindo acesso dentro da engine

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        #region Parte da aula de Enumerator

        //movimentação basica com translate
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5f);
            dirPlayer = Directions.cima;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * Time.deltaTime * 5f);
            dirPlayer = Directions.baixo;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * 5f);
            dirPlayer = Directions.esquerda;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5f);
            dirPlayer = Directions.direita;
        }

        //cadeia de ifs que controla os botões que alteram as cores do player afetado por status effects
        if (Input.GetKey(KeyCode.Alpha1))
        {
            playerStatus = statusEffects.burn;

        }
        

        if (Input.GetKey(KeyCode.Alpha2))
        {
            playerStatus = statusEffects.poison;
        }
        
        if (Input.GetKey(KeyCode.Alpha3))
        {
            playerStatus = statusEffects.frozen;
        }
        




         
          
          if (playerStatus == statusEffects.burn)
        {
            Debug.LogError("Burning Up!!");
            objectRenderer.material.color = Color.red;
        }
        
        if (playerStatus == statusEffects.poison) 
        {
            Debug.LogError("Poisoned!!");
            objectRenderer.material.color = Color.purple;
        }
        
        if (playerStatus == statusEffects.frozen)
        {
            Debug.LogError("Frozen!!");
            objectRenderer.material.color = Color.blue;
        }
        
        #endregion
    }

    void StatusChanger() //modifica a dificuldade
    {
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.easy:
                atk = 5;
                def = 5;
                break;
        }
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.medium:
                atk = 7;
                def = 5;
                break;
        }
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.hard:
                atk = 10;
                def = 0;
                break;
        }
    }
    public void Destruir()
    {

    }

    public void SofrerDano(float dano)
    {

    }
}
