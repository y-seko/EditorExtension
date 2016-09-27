using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	
	public class CheckBoxListView : VerticalLayout, IToggleEventReceiver {

		public enum CheckType {
			Singuler,	// 単数選択
			Multiple,	// 複数選択
		};
		CheckType checkType = CheckType.Singuler;

		// View
		VerticalLayout vLayout;
		Label headerLabel;
		ListView<CheckBoxListViewCell, string> listView;

		public CheckBoxListView(BaseView parent, CheckType type) : base(parent) {
			checkType = type;
			CreateViews (parent);
		}

		/// <summary>
		/// Creates the views.
		/// </summary>
		/// <param name="parent">Parent.</param>
		void CreateViews(BaseView parent) {
			headerLabel = new Label (this, "", "");
			listView = new ListView<CheckBoxListViewCell, string> (this, ListView<CheckBoxListViewCell, string>.Direction.Vertical);
		}

		/// <summary>
		/// Sets the header text.
		/// </summary>
		/// <param name="text">Text.</param>
		public void SetHeaderText(string text) {
			headerLabel.text = text;
		}

		/// <summary>
		/// Sets the item list.
		/// </summary>
		/// <param name="itemList">Item list.</param>
		public void SetItemList(List<string> itemList) {
			listView.SetItemList (itemList);
			foreach (CheckBoxListViewCell c in listView.GetAllCells()) {
				c.toggle.AddReceiver (this);
			}

			if (checkType == CheckType.Singuler) {
				CheckBoxListViewCell cell = listView.GetAllCells () [0];
				cell.toggle.isOn = true;
			}
		}

		/// <summary>
		/// Raises the value changed event.
		/// </summary>
		/// <param name="toggle">Toggle.</param>
		public void OnValueChanged(Toggle toggle) {
			Debug.Log ("CheckListView : OnValueChanged : " + toggle.isOn);

			// 単数選択の場合
			if (checkType == CheckType.Singuler) {
				if (toggle.isOn) {
					foreach (CheckBoxListViewCell cell in listView.GetAllCells()) {
						if (cell.toggle != toggle) {
							cell.toggle.isOn = false;
						}
					}
				}
				else {
					toggle.isOn = true;
				}
			}
		}

		/// <summary>
		/// Gets the checked item list.
		/// </summary>
		/// <returns>The checked item list.</returns>
		public List<string> GetCheckedItemList() {
			List<string> list = new List<string> ();
			foreach (CheckBoxListViewCell cell in listView.GetAllCells()) {
				if (cell.toggle.isOn) {
					list.Add (cell.text);
				}
			}
			return list;
		}
	}

	public class CheckBoxListViewCell : ListViewCell {
		public string text;
		public ToggleLeft toggle { get; private set; }

		public override void CreateView(object obj) {
			text = (string)obj;
			toggle = new ToggleLeft (this, text);
		}
	}
}
