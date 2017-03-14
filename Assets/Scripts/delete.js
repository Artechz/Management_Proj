#pragma strict

public var plano : GameObject;
public var Script : GameObject;
public var dineroManager : GameObject;
public var deletePrefab : deletePrefab;
public var dinero : dinero;
public var startColor : Color;

function Update () {
	Script = GameObject.Find("Script");
	deletePrefab = Script.GetComponent.<deletePrefab>();

	dineroManager = GameObject.Find("Script_Dinero");
	dinero = dineroManager.GetComponent.<dinero>();
}

function OnMouseEnter () {
	if(deletePrefab.deleteTool == true){
		startColor = GetComponent.<Renderer> ().material.color;
		GetComponent.<Renderer>().material.color = Color.red;
	}
}

function OnMouseDown () {
	if(deletePrefab.deleteTool == true){
		dinero.DECsupmrkt();

		Destroy (this.gameObject);
		Instantiate (plano, transform.position + new Vector3 (0.5f, 0, -0.5f), transform.rotation);
	}
}

function OnMouseExit () {
	GetComponent.<Renderer>().material.color = startColor;
}