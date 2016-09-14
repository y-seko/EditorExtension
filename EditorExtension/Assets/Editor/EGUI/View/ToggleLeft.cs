using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// トグルボタン(ボタンが左側にあるタイプ)
	/// </summary>
	public class ToggleLeft : BaseView {

		public string title;
		public bool isOn;

		public ToggleLeft(string title, bool isOn, ViewSkin skin, params GUILayoutOption[] options)
			: base(skin, options) {
			this.title = title;
			this.isOn = isOn;
		}

		public ToggleLeft (string title, bool isOn, ViewSkin skin)
			: this (title, isOn, skin, null) {
		}

		public ToggleLeft (string title, bool isOn, params GUILayoutOption[] options)
			: this (title, isOn, ViewSkin.ToggleLeft, options) {
		}

		public ToggleLeft (string title, bool isOn)
			: this (title, isOn, ViewSkin.ToggleLeft) {
		}

		public ToggleLeft (string title)
			: this (title, false) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			isOn = EditorGUILayout.ToggleLeft (title, isOn, GetGUIStyle(), options);
			base.Draw ();
		}
	}
}