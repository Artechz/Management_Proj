using UnityEditor;
using UnityEngine;

public class calculateScale : EditorWindow{
	float numero = 0f;
	float resultado = 0f;

	// Add menu item named "My Window" to the Window menu
	[MenuItem("Window/Calculador")]
	public static void ShowWindow(){
		//Show existing window instance. If one doesn't exist, make one.
		EditorWindow.GetWindow(typeof(calculateScale));
	}

	void OnGUI(){
		GUILayout.Label ("Calcular Scale", EditorStyles.boldLabel);
		numero = EditorGUILayout.FloatField ("Voxel size", numero);

		resultado = EditorGUILayout.FloatField ("Resultado", (1 / numero) * 2);
	}
}