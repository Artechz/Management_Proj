using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class advise_pass : MonoBehaviour
{
	public Text guitext;

	int number=0;

	float secondsCounter=0;
	float secondsToCount=1;
	int countdown=5;

	void Update ()
	{
		secondsCounter += Time.deltaTime;
		if (secondsCounter >= secondsToCount)
		{
			secondsCounter=0;
			number++;
			countdown--;
		}
		guitext.text = "Time until game starts: " + countdown.ToString();
		if (number >= 5){
			b_menu ();
		}
	}

	public void b_menu(){
		SceneManager.LoadScene(1);
	}
}
