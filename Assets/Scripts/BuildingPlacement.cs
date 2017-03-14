using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {

	private PlaceableBuilding placeableBuilding;
	private Transform currentBuilding;
	private bool hasPlaced;

	public LayerMask buildingsMask;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 m = Input.mousePosition;								
		m = new Vector3 (m.x, m.y, transform.position.y);						//Changing the placin system pending because with this system ~
		Vector3 p = GetComponent<Camera> ().ScreenToWorldPoint (m);			//you can only place looking from an upper position vertically straigh (90º)
		p.x = p.x / 10;
		p.x = Mathf.Round (p.x);
		p.x = p.x * 10;
		p.z = p.z / 10;
		p.z = Mathf.Round (p.z);
		p.z = p.z * 10;

		if (currentBuilding != null && !hasPlaced) {
	
			currentBuilding.position = new Vector3 (p.x, 0, p.z); //Mathf.Round(p.x & p.z) to place it on a "grid" and not wherever they "want"
		
			if (Input.GetMouseButtonDown (0)) {
				if (IsLegalPosition()) {
					hasPlaced = true;
				}
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				RaycastHit hit = new RaycastHit ();
				Ray ray = new Ray(new Vector3(p.x,8,p.z), Vector3.down);	
				if (Physics.Raycast(ray, out hit, Mathf.Infinity, buildingsMask)){
					Debug.Log (hit.collider.name);
				}
			}
		}
	} 

	bool IsLegalPosition () {
		if (placeableBuilding.colliders.Count > 0) {
			return false;
		}
		return true;	
	}

	public void SetItem(GameObject b){
		hasPlaced = false;
		currentBuilding = ((GameObject)Instantiate (b)).transform;
		placeableBuilding = currentBuilding.GetComponent<PlaceableBuilding>();
	}

}
