using UnityEngine;
using UnityEditor;
using System.Collections;

public class MyEditor : MonoBehaviour {
	[MenuItem("MyEditor/Open Window")]
	static void OpenWindow() {
		MyEditorWindow window = (MyEditorWindow)EditorWindow.GetWindow (typeof(MyEditorWindow));
		window.Show ();
	}
}

public class MyEditorWindow : EditorWindow {
	void OnGUI() {
		EditorGUILayout.LabelField ("My Editor");
	}
}
