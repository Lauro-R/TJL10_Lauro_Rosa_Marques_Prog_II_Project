using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager _MainMenuSingleton; // Singleton que cuida do main menu
    [SerializeField]
    private bool _debugMode; //booleana para controlar o modo de debug do codigo acessivel dentro da unity
    public enum MainMenuButtons { listaAulas, options, creditos, sair };
    public enum AulaMenuButtons { Aula1 = 1, Aula2 = 2, Aula3 = 3, Aula4 = 4, Aula5 = 5, Aula6 = 6, Aula7 = 7, Aula8 = 8, Aula9 = 9, Aula10 = 10, Aula11 = 11, Aula12 = 12 };
    public enum SocialButtons { linkedin, github, itch };//enumerator pra manusear os socials
    [SerializeField]
    GameObject telaMenu;
    [SerializeField]
    GameObject telaCredits;
    [SerializeField]
    GameObject telaAulas;
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
            Debug.LogError("Repeated Singleton Alert!! There are more than 1 MainMenuManager's in this scene"); // Debug para avisar se o singleton estiver repetido na cena.
        }
    }

    private void Start()
    {
        OpenMenu(telaMenu);//garante que o jogo sempre reseta para o main menu
    }

    public void MainMenuButtonClicked(MainMenuButtons buttonClicked) 
    {
        DebugMessage("Button funcionando: " + buttonClicked.ToString());// manda a mensagem do debug transformando o botão em string no viewport se debug mode está ligado.
        switch (buttonClicked)
        {
            case MainMenuButtons.listaAulas:
                //PlayClicked();
                OpenMenu(telaAulas);
                break;
            case MainMenuButtons.creditos:
                OpenMenu(telaCredits);
                    break;
            case MainMenuButtons.sair:
                QuitGame();
                break;
            default:
                Debug.Log("Button clicked that wasn't implemented in MainMenuManager Method");
                break;
        }
    }

    public void AulasMenuButtonClicked(AulaMenuButtons buttonClicked)//enum para separar os botões de cada aula
    {
        DebugMessage("Button funcionando: " + buttonClicked.ToString());// manda a mensagem do debug transformando o botão em string no viewport se debug mode está ligado.
        switch (buttonClicked)
        {
            case AulaMenuButtons.Aula1:
                SceneManager.LoadScene(1);
                break;
            case AulaMenuButtons.Aula2:
                SceneManager.LoadScene(2);
                break;
            case AulaMenuButtons.Aula3:
                SceneManager.LoadScene(3);
                break;
            case AulaMenuButtons.Aula4:
                SceneManager.LoadScene(4);
                break;
            case AulaMenuButtons.Aula5:
                SceneManager.LoadScene(5);
                break;
            case AulaMenuButtons.Aula6:
                SceneManager.LoadScene(6);
                break;
            case AulaMenuButtons.Aula7:
                SceneManager.LoadScene(7);
                break;
            case AulaMenuButtons.Aula8:
                SceneManager.LoadScene(8);
                break;
            case AulaMenuButtons.Aula9:
                SceneManager.LoadScene(9);
                break;
            case AulaMenuButtons.Aula10:
                SceneManager.LoadScene(10);
                break;
            case AulaMenuButtons.Aula11:
                SceneManager.LoadScene(11);
                break;
            case AulaMenuButtons.Aula12:
                SceneManager.LoadScene(12);
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

    public void ShowTela(int numTela)
    {
        HideAll();
        switch (numTela)
        {
            case 1:
                telaMenu.SetActive(true);
                break;
            case 2:
                telaCredits.SetActive(true);
                break;
            case 3:
                telaAulas.SetActive(true);
                break;
        }
    }


    public void HideAll()//metodo aprendido em aula basico que esconde todas as telas
    {
        telaMenu.SetActive(false);
        telaCredits.SetActive(false);
        telaAulas.SetActive(false);
    }


    private void DebugMessage(string message) //método para manusear a mensagem acima quando o debug mode está ligado.
    {
        if (_debugMode)
        {
            Debug.Log(message);
        }
    }
            /*public void PlayClicked() //método do Oliver Age 24 que utiliza uma string para carregar as cenas, porém devido os nomes grandes do meu projeto eu removi
            {
                SceneManager.LoadScene(_sceneToLoadAfterClickingPlay);
            }*/

    public void OpenMenu(GameObject menuToOpen)
    {
        // == significa a variavel da direita é o mesmo da esquerda? se não for ele é false
        telaMenu.SetActive(menuToOpen == telaMenu);
        telaCredits.SetActive(menuToOpen == telaCredits);
        telaAulas.SetActive(menuToOpen == telaAulas);
    }

    public void QuitGame()
        { 
            #if UNITY_EDITOR 
                UnityEditor.EditorApplication.ExitPlaymode(); //metodo que encerra o jogo se ele estiver em play mode na unity e voce clica sair
            #else
            Application.Quit(); //if colocado fecha o programa se estiver em alguma plataforma.
            #endif
        }
    }
