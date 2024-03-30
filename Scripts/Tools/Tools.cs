using UnityEngine;

namespace Lancy.Tools
{
    public class Tools : MonoBehaviour
    {
        /// <summary>
        /// Метод, который позволяет открыть какую-либо ссылку
        /// </summary>
        /// <param name="URl">Путь к странице</param>
        public void OpenURL(string URl)
        {
            Application.OpenURL(URl);
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