using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Security.Permissions;

public class LevelEditor : MonoBehaviour {

	public Camera myCamera;

	int tag_suelo = 0;
	int tag_parcela = 1;

	string path = "a:\\documents\\maps\\";
	string map_Name = "caca";
	string fileName;
	string Screenshot_name;

	int vertical;
	int horitzontal;

	GameObject tile;

	public GameObject suelo;
	public GameObject parcela;


	Transform tablero;

	public void Generar () {
		tablero = new GameObject ("Tablero").transform;
		for(int x = 0; x < horitzontal; x++){
			for(int y = 0; y < vertical; y++){
				GameObject Instance = Instantiate(suelo, new Vector3(x,0,y), Quaternion.identity) as GameObject;
				Instance.transform.SetParent (tablero);
			}
		}
	}

	public void Guardar () {
		fileName = path + map_Name + ".txt";

		StreamWriter sw = new StreamWriter (fileName);
		//SUELO
		GameObject[] suelo = GameObject.FindGameObjectsWithTag("suelo");
		foreach(GameObject ojeto in suelo){
			sw.Write (ojeto.transform.position + ","+ tag_suelo + "|");
		}

		//PARCELAS
		GameObject[] parcelas = GameObject.FindGameObjectsWithTag("parcela");
		foreach(GameObject ojeto in parcelas){
			sw.Write (ojeto.transform.position + ","+ tag_parcela + "|");
		}


		sw.Close();

		string text = File.ReadAllText(fileName);
		text = text.Replace("(", "");
		text = text.Replace(")", "");
		text = text.Replace(" ", "");
		File.WriteAllText(fileName, text);

		Screenshot_name = path +  map_Name + ".png";

		RenderTexture rt = new RenderTexture(500, 500, 24);
		myCamera.targetTexture = rt;

		TextureFormat tFormat;
		tFormat = TextureFormat.RGB24;

		Texture2D screenShot = new Texture2D(500, 500, tFormat,false);
		myCamera.Render();
		RenderTexture.active = rt;
		screenShot.ReadPixels(new Rect(0, 0, 500, 500), 0, 0);
		myCamera.targetTexture = null;
		RenderTexture.active = null; 
		byte[] bytes = screenShot.EncodeToPNG();
		string filename = Screenshot_name;

		System.IO.File.WriteAllBytes(filename, bytes);;
	}

	public void Cargar () {
		tablero = new GameObject ("Tablero").transform;
		StreamReader sr = new StreamReader (fileName);
		string text = sr.ReadToEnd ();
		string[] suelo_posiciones = text.Split("|"[0]);
		foreach(string posicion in suelo_posiciones){
			string[] coord = posicion.Split (","[0]);
			float x = float.Parse (coord[0]);
			float y = float.Parse (coord[1]);
			float z = float.Parse (coord[2]);
			int id = int.Parse (coord[3]);

			if(id == 0){
				GameObject Instance = Instantiate(suelo, new Vector3(x,y,z), Quaternion.identity) as GameObject;
				Instance.transform.SetParent (tablero);
			}

			if(id == 1){
				GameObject Instance = Instantiate(parcela, new Vector3(x,y,z), Quaternion.identity) as GameObject;
				Instance.transform.SetParent (tablero);
			}

		}
		sr.Close ();
	}


}