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

		public Toggle (BaseView parent, string title, bool isOn) : base(parent) {
			this.skin = ViewSkin.Toggle;
			this.title = title;
			this.isOn = isOn;
		}

		public Toggle (BaseView parent, string title) : this (parent, title, false) {
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
