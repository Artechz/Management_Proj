#pragma strict
import UnityEngine.UI;
import System.IO;

public var resultado : Text;
public var benefitsT : Text;
public var alerta : Text;
public var timeSreset : Text;
public var button : Button;
public var salesB : Button;
public var supmrktIND : Text;
public var supmrktP : Button;
public var supmrktN : Button;
/* public var dinero_PUBLIC : int;*/
public var dinero : float;
var symbol;
var dollarValue : float;
var poundValue : float;
var yenValue : float;
var divisa : int;
var Veuro : float;
var inmolimit : boolean;
var rednum : boolean;
var timeSres : int;
var TmoneyPOS : float;
var TmoneyNEG : float;
var POSmoneyT : Text;
var NEGmoneyT : Text;
var supmrkt : int;
var supmrktB : int;
var supmrktV : int;
var gains : float;
var looses : float;
var Vbenefits : float;
var benefits : float;

public var Test1 : Text;
var timeRate = 1f;
private var nextTime = 0.0f;
var timeCount = 0;

function Start(){
	Veuro = 1;
	euro();
	dollarValue = 1.106f;
	poundValue = 0.837f;
	yenValue = 117.616f;
	supmrktV = 20;
}

function masDinero(){
	TmoneyPOS += 50;
	Veuro += 50;
	actualizar();
}

function rebaha(){
	TmoneyNEG += 237;
	Veuro = Veuro - 237;
	actualizar();
}

function Update(){
	economy();
	if(Veuro >= 1000){
		inmolimit = true;
	}else if(Veuro <= 0){
		rednum = true;
	}else{inmolimit = false; rednum = false;}
	if(inmolimit == true){
		alerta.text = ("Tienes mucho dinero ಠ_ಠ");
		button.interactable = false;
	}else if(rednum == true){
		alerta.text = ("Te has quedado un poco en la mierda :O");
		salesB.interactable = false;
	}else{alerta.text = (""); button.interactable = true; salesB.interactable = true;}
	actualizar();
}

function euro(){
	divisa = 1;
	actualizar();
}

function dollar(){
	divisa = 2;
	actualizar();
}

function libra(){
	divisa = 3;
	actualizar();
}

function yen(){
	divisa = 4;
	actualizar();
}

function bitcoin(){
	divisa = 5;
	actualizar();
}

function actualizar(){
	if(divisa==1){
		symbol = "€"; // Change money symbol comparedto euro
		dinero = Veuro;  // Specifies currency's value respect to euro
		benefits = Vbenefits;
	}else if(divisa==2){
		symbol = "$"; // Change money symbol to dollar
		dinero = Veuro * dollarValue;
		benefits = Vbenefits * dollarValue;
	}else if(divisa==3){
		symbol = "£"; // Change money symbol to pound
		dinero = Veuro * poundValue;
		benefits = Vbenefits * poundValue;
	}else if(divisa==4){
		symbol = "¥"; // Change money symbol to yen
		dinero = Veuro * yenValue;
		benefits = Vbenefits * yenValue;
	}else if(divisa==5){
		symbol = "¥"; // Change money symbol to euro
		dinero = Veuro * yenValue;
		benefits = Vbenefits * yenValue;
	}
	resultado.text = (dinero.ToString("F2") + " " + symbol);
	benefitsT.text = ("Benefits /sec: " + benefits + " " + symbol);
	POSmoneyT.text = ("Money earned since restart: " + TmoneyPOS + "€");
	NEGmoneyT.text = ("Money wasted since restart: " + TmoneyNEG + "€");
	supmrktIND.text = ("SUPERMARKET (" + supmrkt + ")");
}

function reset(){
	Veuro = 1;
	actualizar();
}

function fastMotion(){
	timeRate = 0.5f;
}

function normalMotion(){
	timeRate = 1f;
}

function INCsupmrkt(){
	if(Veuro >= supmrktV){
	supmrkt ++;
	Veuro -= supmrktV;
	}
}

function DECsupmrkt(){
	if(supmrkt > 0){
	supmrkt --;
	}
}

function economy(){
	supmrktB = supmrkt * 5;
	gains = (supmrktB /** timeRate*/);
	/*TmoneyPOS += gains;*/
	looses = ((supmrkt * 2) /** timeRate*/);
	/*TmoneyNEG += looses;*/
	Vbenefits = gains - looses;
	if(Time.time > nextTime){
		nextTime = Time.time + timeRate;
		timeCount ++;
		Veuro += Vbenefits;
		TmoneyPOS += gains;
		TmoneyNEG += looses;
		Test1.text = ("test_1 = "+ (timeCount /*- timeRate*/));
	}
}

function timeS(){
	timeSreset.text = ("Time since reset: " + timeSres);
}