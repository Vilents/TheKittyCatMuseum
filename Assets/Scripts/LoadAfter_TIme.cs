using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAfter_TIme : MonoBehaviour
{
    float timeoutCounter = 0;
    float TimeoutTime = 120.0f;
    bool IsTimedOut;
    public RectTransform titleScreen;
    void Update()
    {
        // We want to prevent it from counting down while you're on the main screen. Entering from the main menu should set IsTimedOut to false.
        if (!IsTimedOut)
        {
            timeoutCounter += Time.deltaTime;
            if (Input.anyKey || Input.GetAxis("Mouse X") != 0.0f || Input.GetAxis("Mouse Y") != 0.0f)
            {
                timeoutCounter = 0.0f;
            }
            if (timeoutCounter >= TimeoutTime) // TimeoutTime will be a float set to 120.0f for the 2 minute wait time
            {
                IsTimedOut = true;
                titleScreen.gameObject.SetActive(true);
                // Go back to title screen
            }
        }
    }

    public void startCount()
    {
        IsTimedOut = false;
        timeoutCounter = 0.0f;
    }

    private void Start()
    {
        IsTimedOut = true;
    }
}
