using UnityEngine;
using System.Collections;

public class comprarParcela : MonoBehaviour {

	public selectPrefab other;
	public deletePrefab otro;

	int valor = 50;
	int dinero = 200;

	public Color startcolor;

	void Start (){
		GetComponent<Renderer>().material.color = startcolor;
	}

	void OnMouseEnter(){
		if (otro.deleteTool == false) {
			startcolor = GetComponent<Renderer> ().material.color;
			GetComponent<Renderer> ().material.color = Color.yellow;
		}
	}

	void OnMouseExit(){
		GetComponent<Renderer>().material.color = startcolor;
	}

	void OnMouseDown() {
		if (otro.deleteTool == false && dinero >= 50) {
			GetComponent<Renderer> ().material.color = startcolor;
			this.gameObject.tag = "comprado";
			dinero -= valor;
			Debug.Log (dinero);
		}

		else{
			Debug.Log("No tienes suficiente dinero");
		}
	}
}
