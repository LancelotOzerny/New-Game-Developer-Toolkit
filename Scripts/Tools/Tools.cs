using UnityEngine;

namespace Lancy.Tools
{
    public class Tools : MonoBehaviour
    {
        /// <summary>
        /// �����, ������� ��������� ������� �����-���� ������
        /// </summary>
        /// <param name="URl">���� � ��������</param>
        public void OpenURL(string URl)
        {
            Application.OpenURL(URl);
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