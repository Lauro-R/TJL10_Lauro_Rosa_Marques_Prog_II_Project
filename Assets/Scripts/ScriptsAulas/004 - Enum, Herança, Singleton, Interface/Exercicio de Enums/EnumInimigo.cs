using UnityEngine;

public class EnumInimigo : MonoBehaviour, IDamagge, IDestruir
{
    public statusEffects inimigoStatus;

    public float atk;

    void Start()
    {
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.easy:
                atk = 5f;
                break;
        }
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.medium:
                atk = 7f;
                break;
        }
        switch (GameplayManager.myGameplayManager.dificuldadeJogo)
        {
            case Difficulty.hard:
                atk = 10f;
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
