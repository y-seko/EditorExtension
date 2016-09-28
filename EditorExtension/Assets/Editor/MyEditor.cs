﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using EGUI;

public class MyEditor : MonoBehaviour {
	[MenuItem("MyEditor/Open Window")]
	static void OpenWindow() {
		MyEditorWindow window = (MyEditorWindow)EditorWindow.GetWindow (typeof(MyEditorWindow));
		window.Show ();
	}
}

public class MyEditorWindow : Window {
	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
//		VerticalLayoutView layout = new VerticalLayoutView (this.layout);

		Label label = new Label (view, "Hello");
		label.AddOptions (GUILayout.Height(50));

		TextField textField = new TextField (view, "TextField");

	}
}
