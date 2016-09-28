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
	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
		//VerticalLayout layout = new VerticalLayout (this.layout);

		new Label (layout, "Hello");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
		new Label (layout, "Title", "Hello2");
	}
}
