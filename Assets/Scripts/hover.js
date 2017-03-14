#pragma strict

public var startColor : Color;
public var selectPrefab : selectPrefab;
public var deletePrefab : deletePrefab;
public var dinero : dinero;
public var dineroManager : GameObject;
public var Script : GameObject;
var valor : float;
var dineroGame : float;

function Update () {
	dineroManager = GameObject.Find("Script_Dinero");
	dinero = dineroManager.GetComponent.<dinero>();
	Script = GameObject.Find("Script");
	selectPrefab = Script.GetComponent.<selectPrefab>();
	deletePrefab = Script.GetComponent.<deletePrefab>();
}

function Start () {
	GetComponent.<Renderer>().material.color = startColor;
}

function OnMouseEnter () {
	if(deletePrefab.deleteTool == false){
		startColor = GetComponent.<Renderer> ().material.color;
		GetComponent.<Renderer>().material.color = Color.yellow;
	}
}

function OnMouseExit () {
	GetComponent.<Renderer>().material.color = startColor;
}


function OnMouseDown () {
	if(deletePrefab.deleteTool == false && dinero.Veuro >= dinero.supmrktV){
		dinero.INCsupmrkt();

		transform.rotation = Quaternion.Euler(0,90,0);

		GetComponent.<Renderer>().material.color = startColor;
		Instantiate (selectPrefab.prefab, transform.position + new Vector3 (-0.5f, 0, -0.5f), transform.rotation);
		Destroy (this.gameObject);

	}
}