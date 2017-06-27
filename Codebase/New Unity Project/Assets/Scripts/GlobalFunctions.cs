using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class GlobalFunctions  {

    /// <summary>
    /// This is the factory method for causing the buzz sound on a phone
    /// </summary>
	static public void Notify()
    {
        Handheld.Vibrate();
    }
}
