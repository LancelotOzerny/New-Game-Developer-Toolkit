using UnityEngine;

namespace Lancy.Events
{
    public class CTriggerEvent3D : CSingletoonTagEvent
    {
        [SerializeField] private bool debugMode;

        private void OnTriggerEnter(Collider collision)
        {
            if (debugMode)
            {
                Debug.Log($"{this.name}: Trigger with object \"{collision.tag}\"");
            }

            InvokeEventsByGameObject(collision.gameObject);
        }
    }
}