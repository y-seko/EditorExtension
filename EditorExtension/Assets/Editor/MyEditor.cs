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

public class MyEditorWindow : Window, IToggleEventReceiver, IButtonEventReceiver {

	TextField textField;
	TextField textField2;

	Toggle toggle;

	public override void Init() {

		new Label (this.view, "", "Hello");

		HorizontalLayout hLayout = new HorizontalLayout (this.view);
		{
			new Label (hLayout, "Label2", "Hello2");
			new Label (hLayout, "Label3", "Hello3");
		}

		textField = new TextField (this.view, "");

		VerticalLayout vLayout = new VerticalLayout (this.view);
		{
			Button button = new Button (vLayout, "Click", () => {
				textField2.text = textField.text;
			});
			button.size = new Size (100, 0);
			button.AddReceiver (this);

			textField2 = new TextField (vLayout, null, "");
			new Toggle (vLayout, "toggle1", (value) => {
				Debug.Log("" + value);
			}).AddReceiver(this);
			new ToggleLeft (vLayout, "toggle2").AddReceiver(this);
		}
	}

	public void OnValueChanged(Toggle toggle) {
		Debug.Log(toggle.title + " : " + toggle.isOn);
	}

	public void OnClick(Button button) {
		Debug.Log (button.text);
	}
}
