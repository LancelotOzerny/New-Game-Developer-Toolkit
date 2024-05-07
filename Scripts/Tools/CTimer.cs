using UnityEngine;
using UnityEngine.Events;

public class CTimer : MonoBehaviour
{
    [SerializeField] private float time = 1.0f;
    [SerializeField] private UnityEvent endTimerEvent;
    [SerializeField] private bool runOnAwake = false;

    [SerializeField] private float timerTime;
    private bool isActive = false;

    private void Awake()
    {
        if (runOnAwake)
        {
            StartTime();
        }
    }

    private void Update()
    {
        if (isActive == false)
        {
            return;
        }

        timerTime -= Time.deltaTime;
        if (timerTime <= 0.0f)
        {
            endTimerEvent.Invoke();
            isActive = false;
        }
    }

    public void StartTime()
    {
        isActive = true;
        timerTime = time;
    }

    public void ContinueTime()
    {
        isActive = true;
    }

    public void StopTime()
    {
        isActive = false;
    }
}
