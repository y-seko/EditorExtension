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

		public ToggleLeft (string title, bool isOn) {
			this.skin = ViewSkin.ToggleLeft;
			this.title = title;
			this.isOn = isOn;
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