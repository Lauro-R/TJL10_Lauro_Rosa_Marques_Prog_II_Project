using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager _MainMenuSingleton; // Singleton que cuida do main menu
    [SerializeField]
    private bool _debugMode; //booleana para controlar o modo de debug do codigo acessivel dentro da unity
    public enum MainMenuButtons { listaAulas, options, creditos, sair };
    public enum SocialButtons { linkedin, github, itch };//enumerator pra manusear os socials
    [SerializeField]
    private string _sceneToLoadAfterClickingPlay;
    public void Awake()
    {
        if (_MainMenuSingleton == null)//singleton do main menu manager checando se o singleton existe
        {
            _MainMenuSingleton = this;
        }
        else
        {
            Debug.LogError("There are more than 1 MainMenuManager's in this scene"); // Debug para avisar se o singleton estiver repetido na cena.
        }
    }
    public void MainMenuButtonClicked(MainMenuButtons buttonClicked) 
    {
        DebugMessage("Button funcionando: " + buttonClicked.ToString());// manda a mensagem do debug transformando o botão em string no viewport se debug mode está ligado.
        switch (buttonClicked)
        {
            case MainMenuButtons.listaAulas:
                PlayClicked();
                break;
            case MainMenuButtons.options:
                    break;
            case MainMenuButtons.creditos:
                    break;
            case MainMenuButtons.sair:
                QuitGame();
                break;
            default:
                Debug.Log("Button clicked that wasn't implemented in MainMenuManager Method");
                break;
        }
    }
    public void SocialButtonClicked(SocialButtons buttonClicked)
    {
        string websiteLink = "";
        switch (buttonClicked)
        {
            case SocialButtons.linkedin:
                websiteLink = "https://www.linkedin.com/in/lauro-rosa-marques/";
                break;
            case SocialButtons.github:
                websiteLink = "https://github.com/Lauro-R";
                break;
            case SocialButtons.itch:
                websiteLink = "https://laurorosa.itch.io/";
                break;
                default:
                Debug.LogError("Social button clicked but not implemented on SocialbuttonClicked method"); //erro caso você não coloque os links, tolinho
                break;
        }
        if (websiteLink != "") //checa se o link foi trocado
        {
            Application.OpenURL(websiteLink);
        }
    }
    private void DebugMessage(string message) //método para manusear a mensagem acima quando o debug mode está ligado.
    {
        if (_debugMode)
        {
            Debug.Log(message);
        }
    }
            public void PlayClicked()
            {
                SceneManager.LoadScene(_sceneToLoadAfterClickingPlay);
            }
        public void QuitGame()
        { 
            #if UNITY_EDITOR 
                UnityEditor.EditorApplication.ExitPlaymode(); //metodo que para o jogo se ele estiver em play mode na unity
            #else
            Application.Quit(); //if colocado fecha o programa se estiver em alguma plataforma.
            #endif
        }
    }
