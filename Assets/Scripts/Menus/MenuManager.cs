using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput;

    public void OpenSettingsInGame()
    {
        SettingsMenu.instance.OpenSettings();
    }

    public void CloseSettingsInGame()
    {
        if (SettingsMenu.instance != null)
        {
            SettingsMenu.instance.DeactivateSettingsMenu();
        }
    }

    public void ChangeScene(string _sceneName)
    {
        //Loads the scene by its name
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(_sceneName);
    }

    public void ReturnToGame()
    {
        _playerInput.SwitchCurrentActionMap("InGame");
        this.gameObject.SetActive(false);
        SettingsMenu.instance.DeactivateSettingsMenu();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        //Quits the game
        Application.Quit();
    }
}
