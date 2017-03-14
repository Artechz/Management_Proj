using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;

public class volumeo : MonoBehaviour {

	public AudioMixer masterMixer;
	public Slider Music;
	float musicVol = 0.0f;
	public Slider Ambient;
	float ambientVol = 0.0f;
	public Slider FX;
	float FXVol = 0.0f;

	public void Update () {
		musicVol = Music.value;
		ambientVol = Ambient.value;
		FXVol = FX.value;
		masterMixer.SetFloat ("Music", musicVol);
		masterMixer.SetFloat ("Ambient", ambientVol);
		masterMixer.SetFloat ("FX", FXVol);
	}
}
