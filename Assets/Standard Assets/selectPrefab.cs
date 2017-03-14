using UnityEngine;
using System.Collections;

public class selectPrefab : MonoBehaviour {

	public GameObject prefab;
	public GameObject PrefabObj1;
	public GameObject PrefabObj2;
	public GameObject PrefabObj3;


	public void obj1(){
		prefab = PrefabObj1;
	}

	public void obj2(){
		prefab = PrefabObj2;
	}

	public void obj3(){
		prefab = PrefabObj3;
	}
}
