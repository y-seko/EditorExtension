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

public class MyEditorWindow : Window, IButtonEventReceiver, IToggleEventReceiver, ISliderEventReceiver {

	TextField textField;
	TextArea textArea;

	Slider slider;

	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
		Label label = new Label (view, "Label", "Hello");
		label.style = ViewStyle.Box;
		label.AddOptions (GUILayout.Height(20));

		VerticalLayoutView layout = new VerticalLayoutView (view);
		textField = new TextField (layout, "Text Field");

		Button button = new Button (layout, "Click");
		button.AddOptions (GUILayout.Width(70));
		button.AddReceiver (this);

		textArea = new TextArea (layout, "Text Area");

		new Toggle (view, "Toggle").AddReceiver(this);

		new ToggleLeft (view, "Toggle").AddReceiver(this);

		slider = new Slider (view, "Slider", 1, 10, 1);
		slider.AddReceiver (this);
	}

	/// <summary>
	/// Raises the click event.
	/// </summary>
	/// <param name="button">Button.</param>
	public void OnClick(Button button) {
		textArea.text = textField.text;
	}

	/// <summary>
	/// Raises the value changed event.
	/// </summary>
	/// <param name="toggle">Toggle.</param>
	public void OnValueChanged(Toggle toggle) {
		Debug.Log ("OnValueChanged : " + toggle.isCheck);
	}

	/// <summary>
	/// Raises the value changed event.
	/// </summary>
	/// <param name="toggle">Toggle.</param>
	/// <param name="slider">Slider.</param>
	public void OnValueChanged(Slider slider) {
		if (Selection.activeTransform) {
			Selection.activeTransform.localScale = new Vector3 (slider.value, slider.value, slider.value);
		}
	}
}
