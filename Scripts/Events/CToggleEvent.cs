using UnityEngine;
using UnityEngine.Events;

namespace Lancy.Tools
{
    public class CToggleEvent : MonoBehaviour
    {
        [Header("Params")]
        [SerializeField] private bool playOnAwake;
        [SerializeField] private bool state;

        [Header("Events")]
        [SerializeField] private UnityEvent on;
        [SerializeField] private UnityEvent off;

        private void Awake()
        {
            if (playOnAwake)
            {
                Run();
            }
        }

        public void Toggle()
        {
            state = !state;
            Run();
        }

        private void Run()
        {
            if (state)
            {
                On();
            }
            else
            {
                Off();
            }
        }

        private void On()
        {
            on.Invoke();
        }

        private void Off()
        {
            off.Invoke();
        }
    }
}