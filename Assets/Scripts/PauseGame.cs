using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public Menumanager menuManager;

    public void PauseGameToggle(bool condition)
    {
        menuManager.ActivateMenu(condition ? 2 : 0);
        Time.timeScale = condition ? 0 : 1;
    }
}