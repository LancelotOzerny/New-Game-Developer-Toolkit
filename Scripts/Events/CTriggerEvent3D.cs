using UnityEngine;

namespace Lancy.Events
{
    public class CTriggerEvent3D : CSingletoonTagEvent
    {
        private void OnTriggerEnter(Collider collision)
        {
            InvokeEventsByGameObject(collision.gameObject);
        }
    }
}