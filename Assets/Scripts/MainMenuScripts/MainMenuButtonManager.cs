using UnityEngine;

public class MainMenuButtonManager : MonoBehaviour
{
    [SerializeField]
    MainMenuManager.MainMenuButtons _buttontype; //Singleton que gerencia o main menu e quando ele é clicado

    public void ButtonClicked()
    {
        MainMenuManager._MainMenuSingleton.MainMenuButtonClicked(_buttontype);
    }
}
