#pragma strict

//public var type : int;
//public var name : string;
public var limit : boolean;

var Pos;
var FposX;

function Start () {

}

function Update () {
	if(name == "turret"){

		var angle : float;
		angle = gameObject.transform.eulerAngles.y;
		//angle = Quaternion.Angle(Quaternion.Euler(new Vector3(0,0,0)),transform.rotation);
		Debug.Log('Y Rotaton: '+ angle);

		if (limit == false){
			transform.Rotate(0, -30 * Time.deltaTime, 0);
			Debug.Log('LoweringY');
			if(angle >= 299.0 && angle <= 301.0) limit = true;
		}else if (limit == true){
			transform.Rotate(0, 30 * Time.deltaTime, 0);
			Debug.Log('RaisingY');
			if(angle <= 61.0 && angle >= 59.0) limit = false;
		}	
	}
	if(name == "apc"){
	/*	Pos = transform.position.x;
		FposX += Pos;
		Debug.Log('Pos: '+Pos);
		Debug.Log('FposX: '+FposX);	*/
		transform.Translate(Vector3.back * (2 * Time.deltaTime));
	}
	if(name == "wheel" || name == "wheel_fl" || name == "wheel_fr" || name == "wheel_l2" || name == "wheel_r2"){
		transform.Rotate(-150 * Time.deltaTime, 0, 0);
	}
	if(name == "Propellor"){
		transform.Rotate(0, 0, -1500 * Time.deltaTime);
	}
	/*
    if(type == 1){transform.Rotate(0,1500*Time.deltaTime,0);}
    if(type == 2){transform.Rotate(0,500*Time.deltaTime,0);}
    if(type == 3){transform.Rotate(0,-500*Time.deltaTime,0);}
    if(type == 4){transform.Rotate(0,250*Time.deltaTime,0);}
    if(type == 5){transform.Rotate(0,-2500*Time.deltaTime,0);}
    if(type == 6){transform.Rotate(0,-25000*Time.deltaTime,0);}
    */
}
