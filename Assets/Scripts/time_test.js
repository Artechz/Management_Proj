#pragma strict
import UnityEngine.UI;
import System.IO;

public var Test1 : Text;

var timeRate = 0.5;
private var nextTime = 0.0;
var halfSec = 0;

function Start () {

}

function Update () {
	if(Time.time > nextTime){
		nextTime = Time.time + timeRate;
		halfSec ++;
		Test1.text = ("test_1 = "+ halfSec);
	}
}