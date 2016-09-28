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

public class MyEditorWindow : Window, IButtonEventReceiver {

	TextField textField;

	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
//		VerticalLayoutView layout = new VerticalLayoutView (this.layout);

		Label label = new Label (view, "Hello");
		label.AddOptions (GUILayout.Height(50));

		textField = new TextField (view, "TextField");

		Button button = new Button (view, "Click");
		button.AddOptions (GUILayout.Width(70));
		button.AddReceiver (this);
	}

	public void OnClick(Button button) {
		Debug.Log (textField.text);
	}
}
