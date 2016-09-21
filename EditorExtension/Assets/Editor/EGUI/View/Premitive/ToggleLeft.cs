using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// トグルボタン(ボタンが左側にあるタイプ)
	/// </summary>
	public class ToggleLeft : Toggle {
		
		public ToggleLeft (BaseView parent, string title, bool isOn) : base(parent, title, isOn) {
			this.skin = ViewSkin.ToggleLeft;
		}

		public ToggleLeft (BaseView parent, string title) : this (parent, title, false) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			bool prev = isOn;
			isOn = EditorGUILayout.ToggleLeft (title, isOn, GetGUIStyle(), options);
			if (isOn != prev) {
				OnValueChanged ();
			}
//			base.Draw ();
		}
	}
}