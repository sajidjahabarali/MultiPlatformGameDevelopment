using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class LoadSavedTimes: MonoBehaviour {

	public int min;
	public int sec;
	public float milli;
	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MilliDisplay;

	void Start () {

		min = PlayerPrefs.GetInt ("MinSave");
		sec = PlayerPrefs.GetInt ("SecSave");
		milli = PlayerPrefs.GetFloat ("MilliSave");

		MinDisplay.GetComponent<Text> ().text = "" + min + ":";
		SecDisplay.GetComponent<Text> ().text = "" + sec + ".";
		MilliDisplay.GetComponent<Text> ().text = "" + milli;
		
	}
	

}
