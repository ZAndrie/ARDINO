using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [Header("Scene Configuration")]
    [Tooltip("The name of the main menu scene to load.")]
    public string mainMenuSceneName = "main_menu";

    [Tooltip("The name of the AR/Gameplay scene to load.")]
    public string arSceneName = "MAIN_ARCAM";

    [Tooltip("The name of the Info/Security scene to load.")]
    public string infoSceneName = "Main_infosec";

    /// <summary>
    /// Loads the AR Camera Scene.
    /// </summary>
    public void LoadARScene()
    {
        if (!string.IsNullOrEmpty(arSceneName))
        {
            Debug.Log($"Loading AR Scene: {arSceneName}");
            SceneManager.LoadScene(arSceneName);
        }
        else
        {
            Debug.LogError("AR Scene name is empty! Please configure it in the Inspector.");
        }
    }

    /// <summary>
    /// Loads the Main Menu Scene.
    /// </summary>
    public void LoadMainMenu()
    {
        if (!string.IsNullOrEmpty(mainMenuSceneName))
        {
            Debug.Log($"Loading Main Menu Scene: {mainMenuSceneName}");
            SceneManager.LoadScene(mainMenuSceneName);
        }
        else
        {
            Debug.LogError("Main Menu Scene name is empty! Please configure it in the Inspector.");
        }
    }

    /// <summary>
    /// Exits the application. Works in both Build and Unity Editor Play Mode.
    /// </summary>
    public void ExitApp()
    {
        Debug.Log("Exiting Application...");
        Application.Quit();

        // If running inside the Unity Editor, stop the Play mode
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
