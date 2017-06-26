using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Timer nextTimer;
    public int secondsRemaining;
    [SerializeField]
    int maxSeconds;
    bool isTicking;
    [SerializeField]
    Text timerText;

    float timeCount;//This is used to keep track of time until it hits 1, and then we subtract 1 from seconds remaining
    

    // Use this for initialization
    void Start()
    {
        isTicking = false;
        secondsRemaining = maxSeconds;

    }

    // Update is called once per frame
    void Update()
    {
        if (isTicking)//If we're counting down
        {
            timeCount += Time.deltaTime;
            if (timeCount >= 1)
            {
                --secondsRemaining;
                timeCount -= 1;
            }
            

            if (secondsRemaining < 0)
            {
                secondsRemaining = 0;
                TurnTimerOff();
            }

            int tempMinutes = secondsRemaining / 60;
            int tempSeconds = secondsRemaining - tempMinutes * 60;
            timerText.text = tempMinutes + ":" + tempSeconds;

            if (secondsRemaining == 0)
                nextTimer.TurnOnTimer();//We put this here so that way text is forced to be edited correctly.

            
        }
    }


    /// <summary>
    /// This function simply says that the timer is ticking. More than one timer should never be ticking.
    /// </summary>
    public void TurnOnTimer()
    {
        isTicking = true;
    }

    /// <summary>
    /// This turns the timer off and sets seconds remaining to the max time. Its named slightly differently from its counter part because it would be easier to see the differences.
    /// </summary>
    public void TurnTimerOff()
    {
        isTicking = false;
        secondsRemaining = maxSeconds;
    }

    /// <summary>
    /// This lets you set up a timer via code in real time or in editing via serialized fields
    /// </summary>
    /// <param name="InMaxSeconds"> The amount of seconds to run it for</param>
    public void SetUpTimer(int InMaxSeconds)
    {
        maxSeconds = InMaxSeconds;
        secondsRemaining = maxSeconds;
    }
}
