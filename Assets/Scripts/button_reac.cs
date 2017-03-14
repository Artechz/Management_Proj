using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class button_reac : MonoBehaviour {
	public void b_options(){
		SceneManager.LoadScene(3);
	}

	public void b_menu(){
		SceneManager.LoadScene(1);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
