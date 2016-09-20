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

		public Toggle (string title, bool isOn) {
			this.skin = ViewSkin.Toggle;
			this.title = title;
			this.isOn = isOn;
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
