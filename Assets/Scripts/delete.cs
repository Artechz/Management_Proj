using UnityEngine;
using System.Collections;

public class delete : MonoBehaviour {

	public GameObject plano;
	public GameObject objeto;
	public deletePrefab otro;
	public Color startcolor;

	void OnMouseEnter(){
		if (otro.borrarBool == true){
			startcolor = GetComponent<Renderer>().material.color;
			GetComponent<Renderer>().material.color = Color.red;
		}
	}

	void OnMouseDown (){
		if (otro.borrarBool == true) {
			Destroy (objeto);
			Instantiate (plano, transform.position, transform.rotation);
		}
	}

	void OnMouseExit(){
		GetComponent<Renderer>().material.color = startcolor;
	}
}
