using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// トグルボタン
	/// </summary>
	public class Toggle : BaseView {

		public string title;
		public bool isOn;

		public Toggle(string title, bool isOn, ViewSkin skin, params GUILayoutOption[] options)
			: base(skin, options) {
			this.title = title;
			this.isOn = isOn;
		}

		public Toggle (string title, bool isOn, ViewSkin skin)
			: this (title, isOn, skin, null) {
		}

		public Toggle (string title, bool isOn, params GUILayoutOption[] options)
			: this (title, isOn, ViewSkin.Toggle, options) {
		}

		public Toggle (string title, bool isOn)
			: this (title, isOn, ViewSkin.Toggle) {
		}

		public Toggle (string title)
			: this (title, false) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			isOn = EditorGUILayout.Toggle (title, isOn, GetGUIStyle(), options);
			base.Draw ();
		}
	}
}
