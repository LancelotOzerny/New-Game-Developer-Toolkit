using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lancy.Tools
{
    public class Tools : MonoBehaviour
    {
        /// <summary>
        /// Свойство, которое позволяет получить build индекс текущей сцены
        /// </summary>
        public int CurrentScene
        {
            get => SceneManager.GetActiveScene().buildIndex;
        }

        /// <summary>
        /// Метод, который позволяет открыть какую-либо сцену по индексу, если та существует
        /// </summary>
        /// <param name="index">индекс открываемой сцены</param>
        public void OpenSceneByIndex(int index)
        {
            bool currentScene = (index == CurrentScene);
            bool less = (index <= 0);
            bool greather = SceneManager.sceneCountInBuildSettings <= index;

            if (currentScene)
            {
                Debug.LogWarning("Loaded scene - is current scene");
                return;
            }

            if (less || greather)
            {
                Debug.LogWarning("Loaded scene less then zero or greather of max scenes count");
                return;
            }

            SceneManager.LoadScene(index);
        }

        /// <summary>
        /// Метод, который позволяет выйти из игры
        /// </summary>
        public void Quit()
        {
            Application.Quit();
        }
    }
}