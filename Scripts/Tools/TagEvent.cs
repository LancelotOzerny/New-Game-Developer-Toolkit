using UnityEngine.Events;
using UnityEngine;

namespace Lancy.Tools
{
    [System.Serializable]
    public class TagEvent
    {
        [SerializeField] private string tag = string.Empty;
        [SerializeField] private UnityEvent tagEvent = null;
        [SerializeField] private bool destroyCollision = false;
        [SerializeField] private bool destroyThis = false;

        /// <summary>
        /// ��� �������, �� ��������� � �������� ��������� �������
        /// </summary>
        public string Tag
        {
            get => tag;
        }

        /// <summary>
        /// ���������� �� ������������� ������ ����� ������ �������?
        /// </summary>
        public bool DestroyCollision
        {
            get => destroyCollision;
        }

        /// <summary>
        /// ���������� �� ������ ������ ����� ������ �������?
        /// </summary>
        public bool DestroyThis
        {
            get => destroyThis;
        }

        /// <summary>
        /// ���������� ������� ������������� �������
        /// </summary>
        public UnityEvent Event
        {
            get => tagEvent;
        }
    }
}