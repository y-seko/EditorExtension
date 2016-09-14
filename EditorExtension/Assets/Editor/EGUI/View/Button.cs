using UnityEngine;
using UnityEditor;
using System;

namespace EGUI {
	public class Button : Node {
		public string text;
		public Action OnClick;
		public GUILayoutOption[] options;

		public Button(string text, Action OnClick, params GUILayoutOption[] options) {
			this.text = text;
			this.OnClick = OnClick;
			this.options = options;
		}

		public Button(string text, Action OnClick) : this(text, OnClick, null) {
		}

		public override void Draw() {
			if (GUILayout.Button (text, options)) {
				if (OnClick != null) {
					OnClick ();
				}
			}
			base.Draw ();
		}
	}
}
