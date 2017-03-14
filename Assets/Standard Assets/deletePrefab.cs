using UnityEngine;
using System.Collections;

public class deletePrefab : MonoBehaviour {

	public bool borrarBool = false;
	public bool deleteTool = false;

	public void borrar(){
		borrarBool = !borrarBool;
		deleteTool = !deleteTool;
	}

	void Awake (){
		borrarBool = false;
		deleteTool = false;
	}
}