using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public GameObject Script;

	void Start () {
		Instantiate (Script);
	}
}
