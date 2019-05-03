using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishingLap : MonoBehaviour
{
  public GameObject finishingLapTrigger;
	public GameObject halfLapTrigger;

	public GameObject minutesBox;
	public GameObject secondsBox;
	public GameObject milliBox;

	public GameObject LapTimeBox;
    public float rawTime;

	void OnTriggerEnter (Collider collision) {
        if (collision.gameObject.tag != "OpponentCar") {
            rawTime = PlayerPrefs.GetFloat("RawTime");
            if(LapTimeManager.rawTime<=rawTime){
                if (LapTimeManager.secondsPassed <= 9) {
                    secondsBox.GetComponent<Text>().text = "0" + LapTimeManager.secondsPassed + ".";
                } else {
                    secondsBox.GetComponent<Text>().text = "" + LapTimeManager.secondsPassed + ".";
                }

                if (LapTimeManager.minutesPassed <= 9) {
                    minutesBox.GetComponent<Text>().text = "0" + LapTimeManager.minutesPassed + ".";
                } else {
                    minutesBox.GetComponent<Text>().text = "" + LapTimeManager.minutesPassed + ".";
                }

                milliBox.GetComponent<Text>().text = "" + LapTimeManager.milliPassed;
            }

            PlayerPrefs.SetInt("MinSave", LapTimeManager.minutesPassed);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.secondsPassed);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.milliPassed);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

            LapTimeManager.minutesPassed = 0;
            LapTimeManager.secondsPassed = 0;
            LapTimeManager.milliPassed = 0;
            LapTimeManager.rawTime = 0;

            halfLapTrigger.SetActive (true);
            finishingLapTrigger.SetActive (false);
        }

        if (collision.gameObject.tag == "OpponentCar") {
			SceneManager.LoadScene (3);
		}else{
            SceneManager.LoadScene (2);
        }
	}

}
