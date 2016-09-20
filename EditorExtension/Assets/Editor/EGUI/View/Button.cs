using UnityEngine;
using UnityEditor;
using System;

namespace EGUI {
	public class Button : BaseView {
		public string text;
		public Action OnClick;

		public Button(string text, Action OnClick) {
			this.text = text;
			this.OnClick = OnClick;
		}

		public override void Draw() {
			if (GUILayout.Button (text, options)) {
				if (OnClick != null) {
					OnClick ();
				}
				GUIUtility.keyboardControl = 0;
			}
			base.Draw ();
		}
	}
}
