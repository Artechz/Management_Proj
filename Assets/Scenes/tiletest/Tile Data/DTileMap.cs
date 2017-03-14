using UnityEngine;
using System.Collections.Generic;

public class DTileMap {

	protected class DRoom {
	
		//establish all te variables 
		public int left;
		public int top;
		public int width;
		public int height;

		public int right {
			get { return (left + width) - 1; }
		}
	
		public int bottom {
			get { return (top + height) - 1; }
		}

		//Checks if the room would collide with another one already existing
		public bool CollidesWith(DRoom other){
			if (left > other.right)
				return false;

			if (top > other.bottom)
				return false;

			if (right < other.left)
				return false;

			if (bottom < other.top)
				return false;

			return true;
		}
	}

	int size_x;
	int size_y;

	Dictionary<int[,], Tile> map_data;

	List<DRoom> rooms;

	/*
	 *	0 = sand
	 *	1 = grass
	 *	2 = water
	 *	3 = dirt
	 */

	public DTileMap (int size_x, int size_y) {
		this.size_x = size_x;
		this.size_y = size_y;

		map_data = new Dictionary<int[,], Tile>;

		rooms = new List<DRoom>();

		for(int i = 0; i < 20; i++){
			int rsx = Random.Range(4, 8);
			int rsy = Random.Range(4, 8);

			DRoom r = new DRoom();
			r.left = Random.Range(0, size_x - rsx);
			r.top = Random.Range(0, size_y - rsy);
			r.width = rsx;
			r.height = rsy;

			if(!RoomCollides(r)){
			
				rooms.Add(r);
			}
		}

		foreach (DRoom r2 in rooms) {
			MakeRoom (r2);
		}
	}

	bool RoomCollides(DRoom r){
		foreach(DRoom r2 in rooms){
			if(r.CollidesWith(r2)){
				return true;
			}
		}

		return false;
	}

	public int GetTileAt (int x, int y) {
		return map_data [x, y];
	}

	void MakeRoom (DRoom r) {

		for (int x = 0; x < r.width; x++){
			for (int y = 0; y < r.height; y++)  {
				if (x == 0 || x == r.width - 1 || y == 0 || y == r.height - 1) {
					map_data [r.left + x, r.top + y] = 3;
				} else {
					map_data [r.left + x, r.top + y] = 1;
				}
			}
		}

	}
}
