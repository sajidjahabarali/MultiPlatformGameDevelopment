using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject countdownTimer;
	public AudioSource getReady;
	public AudioSource goAudio;
	public GameObject lapTimer;
	public GameObject carControl;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (startCount ());	
    }

    IEnumerator startCount () {
        //wait for half a second
		yield return new WaitForSeconds (0.5f);
		countdownTimer.GetComponent<Text> ().text = "3";
		getReady.Play ();
		countdownTimer.SetActive (true);
		yield return new WaitForSeconds (1);
		countdownTimer.SetActive (false);
		countdownTimer.GetComponent<Text> ().text = "2";
		getReady.Play ();
		countdownTimer.SetActive (true);
		yield return new WaitForSeconds (1);
		countdownTimer.SetActive (false);
		countdownTimer.GetComponent<Text> ().text = "1";
		getReady.Play ();
		countdownTimer.SetActive (true);
		yield return new WaitForSeconds (1);
		countdownTimer.SetActive (false);
		goAudio.Play ();
		lapTimer.SetActive (true);
		carControl.SetActive (true);

	}
}
