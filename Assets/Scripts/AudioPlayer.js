
var hSliderValue : float = 0.0;

function OnGUI () {
	hSliderValue = GUI.HorizontalSlider (Rect(25, 25, 100, 30), hSliderValue, 0.0, 1.0);
	GUI.Label(Rect(100,100,200,20),"Value=" + hSliderValue);
	GetComponent.<AudioSource>().volume = hSliderValue;
}