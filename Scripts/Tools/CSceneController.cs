using UnityEngine;
using UnityEngine.SceneManagement;

public class CSceneController : MonoBehaviour
{
    /// <summary>
    /// Свойство, которое позволяет получить build индекс текущей сцены
    /// </summary>
    public int Current
    {
        get => SceneManager.GetActiveScene().buildIndex;
    }

    /// <summary>
    /// Перезапустить текущую сцену
    /// </summary>
    public void Restart()
    {
        OpenByIndex(Current);
    }

    /// <summary>
    /// Открыть следующую сцену
    /// </summary>
    public void OpenNext()
    {
        OpenByIndex(Current + 1);
    }

    /// <summary>
    /// Открыть предыдущую сцену
    /// </summary>
    public void OpenPrev()
    {
        OpenByIndex(Current - 1);
    }

    private string OpenLevelPrefName = "LastOpenedLevel";
    public void OpenLevel(int level)
    {
        int lastLevel = 0;
        if (PlayerPrefs.HasKey(OpenLevelPrefName))
        {
            lastLevel = PlayerPrefs.GetInt(OpenLevelPrefName);
        }

        PlayerPrefs.SetInt(OpenLevelPrefName, level > lastLevel ? level : lastLevel);
    }

    /// <summary>
    /// Метод, который позволяет открыть какую-либо сцену по индексу, если та существует
    /// </summary>
    /// <param name="index">индекс открываемой сцены</param>
    public void OpenByIndex(int index)
    {
        bool less = (index < 0);
        bool greather = SceneManager.sceneCountInBuildSettings <= index;

        if (less || greather)
        {
            Debug.LogWarning("Loaded scene less then zero or greather of max scenes count");
            return;
        }

        SceneManager.LoadScene(index);
    }
}
