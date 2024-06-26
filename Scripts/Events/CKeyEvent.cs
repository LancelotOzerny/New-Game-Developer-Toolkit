using Lancy.Tools;
using System.Collections.Generic;
using UnityEngine;

namespace Lancy.Events
{
    public class CKeyEvent : MonoBehaviour
    {
        [Header("Event Settings")]
        [SerializeField] private List<KeyEvent> KeyEvent;

        [Header("Debug")]
        [SerializeField] protected bool isDebugMode;

        private void Update()
        {
            foreach (var key in KeyEvent)
            {
                if (Input.GetKeyUp(key.key))
                {
                    if (isDebugMode)
                    {
                        Debug.Log($"{this.name}: press \"{ key }\" key");
                    }

                    key.keyEvent.Invoke();
                }
            }
        }
    }
}