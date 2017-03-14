using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

[CustomEditor(typeof(LevelEditor))]
public class editor : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector ();

		LevelEditor levelEditor = (LevelEditor)target;

		if(GUILayout.Button ("GUARDAR")){
			levelEditor.Guardar ();
		}

		if(GUILayout.Button ("CARGAR")){
			levelEditor.Cargar ();
		}


	}
}
