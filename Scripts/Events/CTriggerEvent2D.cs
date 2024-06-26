using UnityEngine;

namespace Lancy.Events
{
    public class CTriggerEvent2D : CSingletoonTagEvent
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsDebugMode)
            {
                Debug.Log($"{this.name}: Trigger with object \"{collision.tag}\"");
            }

            InvokeEventsByGameObject(collision.gameObject);
        }
    }
}