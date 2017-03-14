using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(test1))]
public class TestInspector : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector ();
		if(GUILayout.Button("Generate")){
			test1 test = (test1)target;
			test.BuildMap ();
		}
	}
}
