using UnityEngine;

namespace Lancy.Events
{
    public class CTriggerEvent2D : CSingletoonTagEvent
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            InvokeEventsByGameObject(collision.gameObject);
        }
    }
}