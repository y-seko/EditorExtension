using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// トグルボタン(ボタンが左側にあるタイプ)
	/// </summary>
	public class ToggleLeft : Toggle {
		
		public ToggleLeft (BaseView parent, string title, bool isOn, Action<bool> OnValueChanged)
			: base(parent, title, isOn, OnValueChanged) {
			this.skin = ViewSkin.ToggleLeft;
		}

		public ToggleLeft (BaseView parent, string title, Action<bool> OnValueChanged)
			: this(parent, title, false, OnValueChanged) {
		}

		public ToggleLeft (BaseView parent, string title) : this (parent, title, false, null) {
		}

		/// <summary>
		/// トグルを描画する
		/// </summary>
		/// <returns>true</returns>
		/// <c>false</c>
		protected override bool DrawToggle() {
			return EditorGUILayout.ToggleLeft (title, isOn, GetGUIStyle(), options);;
		}
	}
}