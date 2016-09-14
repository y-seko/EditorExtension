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
		this.AddChild (new Label ("", "Hello"));

		HorizontalLayout hLayout = new HorizontalLayout ();
		this.AddChild (hLayout);
		{
			hLayout.AddChild (new Label ("Label2", "Hello2"));
			hLayout.AddChild (new Label ("Label3", "Hello3"));
		}

		textField = new TextField ("");
		this.AddChild (textField);

		VerticalLayout vLayout = new VerticalLayout ();
		this.AddChild (vLayout);
		{
			vLayout.AddChild (new Button ("Click", () => {
				textField2.text = textField.text;
			}, GUILayout.Width (50)));

			textField2 = new TextField (null, "");
			vLayout.AddChild (textField2);

			vLayout.AddChild (new Toggle ("toggle1", false));

			vLayout.AddChild (new ToggleLeft ("toggle2", false));
		}
	}
}
