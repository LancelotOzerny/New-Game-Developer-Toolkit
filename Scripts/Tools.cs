using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lancy.Tools
{
    public class Tools : MonoBehaviour
    {
        /// <summary>
        /// ��������, ������� ��������� �������� build ������ ������� �����
        /// </summary>
        public int CurrentScene
        {
            get => SceneManager.GetActiveScene().buildIndex;
        }

        /// <summary>
        /// �����, ������� ��������� ������� �����-���� ����� �� �������, ���� �� ����������
        /// </summary>
        /// <param name="index">������ ����������� �����</param>
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
        /// �����, ������� ��������� ����� �� ����
        /// </summary>
        public void Quit()
        {
            Application.Quit();
        }
    }
}