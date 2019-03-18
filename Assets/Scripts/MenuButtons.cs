using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Board");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}