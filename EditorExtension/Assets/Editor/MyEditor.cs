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

		CheckBoxListView checkListView = new CheckBoxListView (this.view, CheckBoxListView.CheckType.Multiple);
		checkListView.SetHeaderText ("Check List");
		checkListView.SetItemList (new List<string>(){
			"Item 1",
			"Item 2",
			"Item 3",
		});

		ListView<ItemCell, Item> view = new ListView<ItemCell, Item> (this.view, ListView<ItemCell, Item>.Direction.Vertical);
		view.SetItemList (new List<Item> () {
			new Item("Item1", "Apple"),
			new Item("Item2", "Orange"),
		});
	}

	public void OnValueChanged(Toggle toggle) {
		Debug.Log(toggle.title + " : " + toggle.isOn);
	}

	public void OnClick(Button button) {
		Debug.Log (button.text);
	}
}

public class Item {
	public string name;
	public string text;
	public Item(string name, string text) {
		this.name = name;
		this.text = text;
	}
}

public class ItemCell : ListViewCell {
	public override void CreateView(object obj) {
		Item item = (Item)obj;
		new Label (this, item.name, "");
		new Label (this, null, item.text);
	}
}
