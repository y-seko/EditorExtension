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

	FloatSlider floatSlider;
	IntSlider intSlider;

	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
		Label label = new Label (view, "Label", "Hello");
		label.style = ViewStyle.Box;
		label.AddOptions (GUILayout.Height(20));

		VerticalLayoutView layout = new VerticalLayoutView (view);
		{
			textField = new TextField (layout, "Text Field");

			Button button = new Button (layout, "Click");
			button.AddOptions (GUILayout.Width (70));
			button.AddReceiver (this);

			textArea = new TextArea (layout, "Text Area");
		}

		VerticalLayoutView layout2 = new VerticalLayoutView (view);
		{
			new Toggle (layout2, "Toggle").AddReceiver (this);
			new ToggleLeft (layout2, "Toggle").AddReceiver (this);
		}

		floatSlider = new FloatSlider (view, "Float", 1, 10, 1);
		floatSlider.AddReceiver (this);

		intSlider = new IntSlider (view, "Int", 1, 10, 1);
		intSlider.AddReceiver (this);
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
		if (slider == floatSlider) {
			if (Selection.activeTransform) {
				float value = ((FloatSlider)slider).value;
				Selection.activeTransform.localScale = new Vector3 (value, value, value);
			}
		}
		else if (slider == intSlider) {
			int value = ((IntSlider)slider).value;
			Debug.Log ("value : " + value);
		}
	}
}
