using UnityEngine;
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
	public override void OnCreateView() {
		VerticalLayout layout = new VerticalLayout ();
		AddView (layout);

		Label label = new Label ();
		layout.AddChild (label);
	}
}

public class Label : BaseView {
	public override void OnDraw() {
		EditorGUILayout.LabelField ("", "Hello");
	}
}

public class VerticalLayout : BaseLayout {
	public override void OnDraw() {
		EditorGUILayout.BeginVertical ();
		DrawChildren ();
		EditorGUILayout.EndVertical ();
	}
}
