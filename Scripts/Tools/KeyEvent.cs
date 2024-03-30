using UnityEngine;
using UnityEngine.Events;

namespace Lancy.Tools
{
    [System.Serializable]
    public class KeyEvent
    {
        public KeyCode key;
        public UnityEvent keyEvent;
    }
}
