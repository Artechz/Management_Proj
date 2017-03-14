using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevDisplay : MonoBehaviour {

	public Text timeInd;
	public Text FPSInd;

	float deltaTime = 0.0f;

	int seconds = 0;
	int Timer = 0;

	float timeCount = 0;
	float timeRate = 1;
	float timeCount2 = 0;
	float timeRate2 = 0.25f;

	bool DvMOn = false;

	void Update () {

		if (Input.GetKeyDown (KeyCode.F7)) {
			DvMOn = !DvMOn;
		}

		if (DvMOn) {

			deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
			float fps = 1.0f / deltaTime;

			timeCount += Time.deltaTime;
			timeCount2 += Time.deltaTime;

			if (timeCount >= timeRate) {
				timeCount = 0;
				seconds++;
			}

			if (timeCount2 >= timeRate2) {
				timeCount2 = 0;
				Timer++;

				fps = Mathf.Round (fps);
				FPSInd.text = "FPS = " + fps.ToString ();
				timeInd.text = "Time = " + seconds.ToString ();
			}
		} else {
			FPSInd.text = " ";
			timeInd.text = " ";
		}

	}

}
