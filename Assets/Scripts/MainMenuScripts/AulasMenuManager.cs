using UnityEngine;

public class AulasMenuManager : MonoBehaviour
{
    [SerializeField]
    MainMenuManager.AulaMenuButtons _buttontype;
    public void AulasClicked()
    {
        MainMenuManager._MainMenuSingleton.AulasMenuButtonClicked(_buttontype);
    }
}
