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
        /// �����, ������� ��������� �������� ��� ������� tagEvents �������
        /// </summary>
        protected List<TagEvent> TagEvents
        {
            get
            {
                return tagEvents;
            }
        }

        /// <summary>
        /// �����, ������� �� GameObject ���������� ��������� ������� �� ����������� ��� � �������� ��� ����������
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