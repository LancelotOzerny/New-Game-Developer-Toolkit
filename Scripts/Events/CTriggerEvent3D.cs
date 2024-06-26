using UnityEngine;

namespace Lancy.Events
{
    public class CTriggerEvent3D : CSingletoonTagEvent
    {
        private void OnTriggerEnter(Collider collision)
        {
            if (IsDebugMode)
            {
                Debug.Log($"{this.name}: Trigger with object \"{collision.tag}\"");
            }

            InvokeEventsByGameObject(collision.gameObject);
        }
    }
}