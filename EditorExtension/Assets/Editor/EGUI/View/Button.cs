using UnityEngine;
using UnityEditor;
using System;

namespace EGUI {
	public class Button : BaseView {
		public string text;
		public Action OnClick;
		public GUILayoutOption[] options;

		public Button(string text, Action Onclick, ViewSkin skin, params GUILayoutOption[] options) 
			: base(skin, options) {
			this.text = text;
			this.OnClick = OnClick;
		}

		public Button(string text, Action OnClick, params GUILayoutOption[] options)
			: this(text, OnClick, ViewSkin.None, options) {
		}

		public Button(string text, Action OnClick) : this(text, OnClick, null) {
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
