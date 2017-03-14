#pragma strict
import UnityEngine.UI;

var isPause = false;
var sirenThings : GameObject;

function Update () {
	if( Input.GetKeyDown(KeyCode.T)){
		isPause = !isPause;
		if(isPause == true){
			sirenThings.SetActive(true);
		}
		else{
			sirenThings.SetActive(false);
		}
	}
}
