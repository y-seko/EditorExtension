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

		public ToggleLeft (BaseView parent, string title, bool isOn) : base(parent) {
			this.skin = ViewSkin.ToggleLeft;
			this.title = title;
			this.isOn = isOn;
		}

		public ToggleLeft (BaseView parent, string title) : this (parent, title, false) {
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