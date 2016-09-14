using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using EGUI;

public class MyEditor : MonoBehaviour {
	[MenuItem("MyEditor/Open Window")]
	static void OpenWindow() {
		MyEditorWindow window = (MyEditorWindow)EditorWindow.GetWindow (typeof(MyEditorWindow));
		window.Show ();
	}
}

public class MyEditorWindow : Window {
	public override void Init() {
		this.AddChild (new Label ("", "Hello"));

		HorizontalLayout hLayout = new HorizontalLayout ();
		this.AddChild (hLayout);

		hLayout.AddChild (new Label ("Label2", "Hello2"));
		hLayout.AddChild (new Label ("Label3", "Hello3"));
	}
}
