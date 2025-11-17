using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
   public void ReturnToTitle()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
