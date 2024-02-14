using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInstaller : MonoBehaviour
{
    private static string  SceneKey="";

    public static void SaveCurrentScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString(SceneKey, currentSceneName);
    }

    public static void LoadSavedScene()
    {
        if (PlayerPrefs.HasKey(SceneKey))
        {
            string savedSceneName = PlayerPrefs.GetString(SceneKey);
            SceneManager.LoadScene(savedSceneName);
        }
    }
}
