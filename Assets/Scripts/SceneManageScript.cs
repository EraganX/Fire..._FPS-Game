using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Training");
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Menu");
    }


    
}
