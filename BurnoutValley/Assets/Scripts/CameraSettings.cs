using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour {

	public GameObject DefaultCamera;
	public GameObject FarCamera;
	public GameObject DriverCamera;
	public int CamMode;

	void Update () {
		if (Input.GetButtonDown ("Viewmode")) {
			if (CamMode == 2) {
				CamMode = 0;
			} else {
				CamMode += 1;
			}
			StartCoroutine (ModeChange ());
		}
	}

	IEnumerator ModeChange () {
		yield return new WaitForSeconds (0.01f);
		if (CamMode == 0) {
			DefaultCamera.SetActive (true);
			DriverCamera.SetActive (false);
		}
		if (CamMode == 1) {
			FarCamera.SetActive (true);
			DefaultCamera.SetActive (false);
		}
		if (CamMode == 2) {
			DriverCamera.SetActive (true);
			FarCamera.SetActive (false);
		}

	}
}
