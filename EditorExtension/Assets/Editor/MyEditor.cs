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

public class MyEditorWindow : Window, IButtonEventReceiver, IToggleEventReceiver, ISliderEventReceiver, IEnumPopupEventReceiver {

	TextField textField;
	TextArea textArea;

	FloatSlider floatSlider;
	IntSlider intSlider;

	PropertyField propertyField;

	Button activeButton;

	VerticalLayoutView vLayout4;

	public enum MyItem{
		Item1,
		Item2,
		Item3,
	}

	/// <summary>
	/// ビューの作成
	/// </summary>
	public override void OnCreateView() {
		Label label = new Label (view, "Label", "Hello");
		label.style = ViewStyle.Box;
		label.AddOptions (GUILayout.Height(20));

		VerticalLayoutView layout = new VerticalLayoutView (view);
		{
			HorizontalLayoutView hLayout = new HorizontalLayoutView (layout);
			hLayout.style = ViewStyle.None;
			{
				textField = new TextField (hLayout, "Text Field");

				Button button = new Button (hLayout, "Copy");
				button.AddOptions (GUILayout.Width (70));
				button.AddReceiver (this);
			}

			textArea = new TextArea (layout, "Text Area");
		}

		new EGUI.Space (view);

		VerticalLayoutView layout2 = new VerticalLayoutView (view);
		{
			new Toggle (layout2, "Toggle").AddReceiver (this);
			new ToggleLeft (layout2, "Toggle").AddReceiver (this);
		}

		new EGUI.Space (view);

		floatSlider = new FloatSlider (view, "Float", 1, 10, 1);
		floatSlider.AddReceiver (this);

		intSlider = new IntSlider (view, "Int", 1, 10, 1);
		intSlider.AddReceiver (this);

		EnumPopup popup = new EnumPopup (view, MyItem.Item1);
		popup.AddReceiver (this);

		VerticalLayoutView layout3 = new VerticalLayoutView (view);
		{
			MyObject obj = ScriptableObject.CreateInstance<MyObject> ();
			SerializedObject serializedObject = new SerializedObject (obj);
			propertyField = new PropertyField (layout3, serializedObject.FindProperty ("myVector"));
		}

		new IntField (view, "Int Field", 100);

		activeButton = new Button (view, "Atcive");
		activeButton.AddOptions (GUILayout.Width (50));
		activeButton.AddReceiver (this);

		vLayout4 = new VerticalLayoutView (view);
		{
			new Label (vLayout4, "Hello");
		}

		List<MyListItem> list = new List<MyListItem> () {
			new MyListItem("Item1"),
			new MyListItem("Item2"),
			new MyListItem("Item3"),
		};

		MyListView listView = new MyListView (view);
		listView.SetItemList (list);
	}

	/// <summary>
	/// Raises the click event.
	/// </summary>
	/// <param name="button">Button.</param>
	public void OnClick(Button button) {
		if (button == activeButton) {
			vLayout4.active = !vLayout4.active;
		}
		else {
			textArea.text = textField.text;
		}
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

	public void OnValueChanged(EnumPopup popup) {
		Debug.Log ("Enum : " + popup.value.ToString());
	}
}

public class MyObject : ScriptableObject {
	public int myInt = 100;
	public Vector3 myVector;
}

public class MyListItem {
	public string text;
	public MyListItem(string text) {
		this.text = text;
	}
}

public class MyListView : ListView<MyListItem> {

	public MyListView(BaseLayoutView parent) : base(parent, Direction.Vertical) {
	}

	public override void CreateCell (MyListItem item) {
		HorizontalLayoutView hLayout = new HorizontalLayoutView (this);
		new Label(hLayout, item.text);
		new Button(hLayout, "Click");
	}
}
