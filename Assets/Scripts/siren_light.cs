using UnityEngine;
using System.Collections;

public class siren_light : MonoBehaviour {
	bool sirenActivated = false;
public float waitingTime;
IEnumerator Start ()
{
		while (true) {
			if (Input.GetKey (KeyCode.T)) {
				sirenActivated = !sirenActivated;
			}
			while(sirenActivated){
				GetComponent<Light> ().enabled = !(GetComponent<Light> ().enabled); //toggle on/off the enabled property
				yield return new WaitForSeconds (waitingTime);
			}
		}

}

/*void update(){
		if (Input.GetKey (KeyCode.T)) {
			sirenActivated = !sirenActivated;
		}
		while(sirenActivated){
			GetComponent<Light> ().enabled = !(GetComponent<Light> ().enabled); //toggle on/off the enabled property
			yield return new WaitForSeconds (waitingTime);
		}
	}
	*/
}