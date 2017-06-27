using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCreator : MonoBehaviour {
    [SerializeField]
    bool isMinutes;//Check this to let the script know it holds minutes 
    public Text NumbersOnlyTextField;
   // string lastText;//Text from the last frame

    [SerializeField]
    Timer timerToSet;//You only need this if you're the seconds timer, otherwsie youll send your time to the seconds timer

    [SerializeField]
    TimerCreator SecondsTimer;//Only use this if you're the minute timer, otherwise youll end up setting the time
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        

        
	}

   // public void ValidateFunction()
   // {
   //     int temp;
   //     if (!int.TryParse(NumbersOnlyTextField.text, out temp))//This checks if the text is all numbers or not
   //         NumbersOnlyTextField.text = lastText;//This resets the numbers only field to the last known good text field
   //
   //     lastText = NumbersOnlyTextField.text;
   // }

    public void SetTimer()
    {
        if (isMinutes)
        {
            int tempMinutes = 0;
            int tempSeconds = 0;

            #region Error checking for null input in the input boxes

            //Minutes 
            if(NumbersOnlyTextField.text.Length > 0)
            tempMinutes =  int.Parse(NumbersOnlyTextField.text) * 60;
            //Seconds
            if(SecondsTimer.NumbersOnlyTextField.text.Length > 0)
            tempSeconds = int.Parse(SecondsTimer.NumbersOnlyTextField.text);

            #endregion

            int totalTime = tempSeconds + tempMinutes;
            timerToSet.SetUpTimer(totalTime);
            
        }
        else
        {
            
            
        }
    }
}
