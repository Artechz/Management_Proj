using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimePass : MonoBehaviour
{
	public Text guitext;

	int number=0;

	float secondsCounter=0;
	float secondsToCount=1;

	void Update ()
	{
		secondsCounter += Time.deltaTime;
		if (secondsCounter >= secondsToCount)
		{
			secondsCounter=0;
			number++;
		}
		guitext.text = "Time since restart: " + number.ToString();
	}
}