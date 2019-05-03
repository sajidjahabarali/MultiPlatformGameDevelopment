using System.ComponentModel;
using System.Resources;
//using System.ComponentModel.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
   public GameObject minutesBox;
   public GameObject secondsBox;
   public GameObject millibox;
   public static int minutesPassed;
   public static int secondsPassed;
   public static float milliPassed;
   public static String milliDisplay;
   public static float rawTime;
   

    // Update is called once per frame
    void Update()
    {
        milliPassed += Time.deltaTime * 10;
        rawTime += Time.deltaTime;
        milliDisplay = milliPassed.ToString("F0");
        millibox.GetComponent<Text>().text = "" + milliDisplay;

        if (milliPassed >= 10) {
			milliPassed = 0;
			secondsPassed += 1;
		}

		if (secondsPassed <= 9) {
			secondsBox.GetComponent<Text> ().text = "0" + secondsPassed + ".";
		} else {
			secondsBox.GetComponent<Text> ().text = "" + secondsPassed + ".";
		}

		if (secondsPassed >= 60) {
			secondsPassed = 0;
			minutesPassed += 1;
		}

		if (minutesPassed <= 9) {
			minutesBox.GetComponent<Text> ().text = "0" + minutesPassed + ":";
		} else {
			minutesBox.GetComponent<Text> ().text = "" + minutesPassed + ":";
		}



    }
}
