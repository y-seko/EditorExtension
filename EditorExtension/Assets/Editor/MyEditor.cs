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

			textField2 = new TextField (vLayout, null, "");
			new Toggle (vLayout, "toggle1");
			new ToggleLeft (vLayout, "toggle2");
		}
	}
}
