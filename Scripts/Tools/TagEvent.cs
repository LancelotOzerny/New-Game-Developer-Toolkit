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
        /// Тег объекта, по отношению к которому вызываеся событие
        /// </summary>
        public string Tag
        {
            get => tag;
        }

        /// <summary>
        /// Уничтожить ли соприкасаемый объект после вызова события?
        /// </summary>
        public bool DestroyCollision
        {
            get => destroyCollision;
        }

        /// <summary>
        /// Уничтожить ли данный объект после вызова события?
        /// </summary>
        public bool DestroyThis
        {
            get => destroyThis;
        }

        /// <summary>
        /// Вызываемое событие тегированного объекта
        /// </summary>
        public UnityEvent Event
        {
            get => tagEvent;
        }
    }
}