#pragma strict
import UnityEngine.UI;

var isPause = false;
var pauseMenu : GameObject;

function Update () {
	if( Input.GetKeyDown(KeyCode.Escape)){
		if(isPause == true){
			pause();
		}
		else{
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
			isPause = !isPause;
		}
	}
}

function pause(){
	Time.timeScale = 0;
	pauseMenu.SetActive(true);
	isPause = !isPause;
}