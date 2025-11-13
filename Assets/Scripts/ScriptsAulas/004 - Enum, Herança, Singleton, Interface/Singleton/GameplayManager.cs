using UnityEngine;

//Singleton que controla elementos que podem ser utilizados em cada outro codigo
public class GameplayManager : MonoBehaviour
{
    public Difficulty dificuldadeJogo;

    public static GameplayManager myGameplayManager;
    private void Awake()
    {
        if (myGameplayManager != null && myGameplayManager != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            myGameplayManager = this;
        }

        DontDestroyOnLoad(this);
        /*if que garante que nunca existirá outro Singleton repetido desse numa cena*/
    }
}
