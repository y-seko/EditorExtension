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

public class MyEditorWindow : Window, IButtonEventReceiver, IToggleEventReceiver {

	TextField textField;

	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
//		VerticalLayoutView layout = new VerticalLayoutView (this.layout);

		Label label = new Label (view, "Label", "Hello");
		label.AddOptions (GUILayout.Height(50));

		textField = new TextField (view, "Text Field");

		Button button = new Button (view, "Click");
		button.AddOptions (GUILayout.Width(70));
		button.AddReceiver (this);

		new TextArea (view, "Text Area");

		new Toggle (view, "Toggle").AddReceiver(this);
	}

	/// <summary>
	/// Raises the click event.
	/// </summary>
	/// <param name="button">Button.</param>
	public void OnClick(Button button) {
		Debug.Log (textField.text);
	}

	/// <summary>
	/// Raises the value changed event.
	/// </summary>
	/// <param name="toggle">Toggle.</param>
	public void OnValueChanged(Toggle toggle) {
		Debug.Log ("OnValueChanged : " + toggle.isCheck);
	}
}
