using UnityEngine;
using System.Collections;

public class siren_light1 : MonoBehaviour {

public float waitingTime=0.05f;
IEnumerator Start ()
{	
	yield return new WaitForSeconds(waitingTime);

	while (true)
	{
		GetComponent<Light>().enabled = !(GetComponent<Light>().enabled); //toggle on/off the enabled property
		yield return new WaitForSeconds(waitingTime);
	}
}
}