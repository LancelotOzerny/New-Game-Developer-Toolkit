using Lancy.Tools;
using System.Collections.Generic;
using UnityEngine;

namespace Lancy.Events
{
    public class CKeyEvent : MonoBehaviour
    {
        [Header("Event Settings")]
        [SerializeField] private List<KeyEvent> KeyEvent;

        private void Update()
        {
            foreach (var key in KeyEvent)
            {
                if (Input.GetKeyUp(key.key))
                {
                    key.keyEvent.Invoke();
                }
            }
        }
    }
}