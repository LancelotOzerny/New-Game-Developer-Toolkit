using System.Collections.Generic;
using UnityEngine;
using Lancy.Tools;

namespace Lancy.Events
{
    public class CSingletoonTagEvent : MonoBehaviour
    {
        [Header("Event Settings")]
        [SerializeField] private List<TagEvent> tagEvents;

        /// <summary>
        /// ћетод, который позвол€ет получить все текущие tagEvents объекта
        /// </summary>
        protected List<TagEvent> TagEvents
        {
            get
            {
                return tagEvents;
            }
        }

        /// <summary>
        /// ћетод, который по GameObject экзмепл€ру провер€ет событи€ на аналогичный тег и вызывает все совпадени€
        /// </summary>
        /// <param name="collision"></param>
        protected void InvokeEventsByGameObject(GameObject collision)
        {
            foreach (TagEvent tagEvent in this.TagEvents)
            {
                if (collision.tag == tagEvent.Tag)
                {
                    tagEvent.Event.Invoke();

                    if (tagEvent.DestroyCollision)
                    {
                        Destroy(collision);
                    }

                    if (tagEvent.DestroyThis)
                    {
                        Destroy(this.gameObject);
                    }
                }
            }
        }
    }
}