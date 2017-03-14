using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	public int MAP_Height;
	public int MAP_Width;

	public GameObject tile; //single
	GameObject Tile; //group

	// Use this for initialization
	public void BuildMap () {
		
		Transform TileGroup = new GameObject("TileGroup").transform;

		int y2 = 5;
		int x2 = 5;

		for(int y = 0; y < MAP_Height; y++){
			for(int x = 0; x < MAP_Width; x ++){
				//Instantiate tile. position is x = TILE_Width * x   y = TILE_Height * y
				Tile = Instantiate(tile, new Vector3(x2, 0, y2), transform.rotation * Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
				Tile.transform.SetParent(TileGroup);
				x2 += 10;
			}
			y2 += 10;
			x2 = 5;
		}

	}

	void Start () {
		BuildMap ();
	}
}
