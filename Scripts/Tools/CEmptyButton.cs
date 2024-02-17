using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine;

namespace Lancy.Tools
{
    public class CEmptyButton : MonoBehaviour,
                                IPointerUpHandler,
                                IPointerDownHandler,
                                IPointerClickHandler,
                                IPointerEnterHandler,
                                IPointerExitHandler
    {
        [Header("Button Events")]
        [SerializeField] private UnityEvent onClick = null;
        [SerializeField] private UnityEvent onDown = null;
        [SerializeField] private UnityEvent onUp = null;
        [SerializeField] private UnityEvent onEnter = null;
        [SerializeField] private UnityEvent onExit = null;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (onClick != null)
            {
                onClick.Invoke();
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (onDown != null)
            {
                onDown.Invoke();
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (onUp != null)
            {
                onUp.Invoke();
            }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (onEnter != null)
            {
                onEnter.Invoke();
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (onExit != null)
            {
                onExit.Invoke();
            }
        }
    }
}
