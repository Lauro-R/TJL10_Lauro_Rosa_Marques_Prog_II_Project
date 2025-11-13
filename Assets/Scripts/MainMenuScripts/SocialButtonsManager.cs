using UnityEngine;

public class SocialButtonsManager : MonoBehaviour
{
    [SerializeField]
    MainMenuManager.SocialButtons _buttontype; //Singleton que gerencia o social button e quando ele é clicado

    public void ButtonClicked()
    {
        MainMenuManager._MainMenuSingleton.SocialButtonClicked(_buttontype);
    }
}
