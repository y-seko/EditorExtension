using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {

	public enum ViewSkin {
		None,
		Box,
		Label,
		TextField,
		Toggle,
		ToggleLeft,
	}

	/// <summary>
	/// 基底クラス
	/// </summary>
	public abstract class BaseView : Node {
		public ViewSkin skin;
		public GUILayoutOption[] options;

		public BaseView(ViewSkin skin, params GUILayoutOption[] options) {
			this.skin = skin;
			this.options = options;
		}

		/// <summary>
		/// GUIStyleを取得する.
		/// </summary>
		/// <returns>The GUI style.</returns>
		protected GUIStyle GetGUIStyle() {
			switch (skin) {
			case ViewSkin.Box:
				return GUI.skin.box;
			case ViewSkin.Label:
				return GUI.skin.label;
			case ViewSkin.TextField:
				return GUI.skin.textField;
			case ViewSkin.Toggle:
				return GUI.skin.toggle;
			case ViewSkin.ToggleLeft:
				return GUI.skin.label;
			}
			return GUIStyle.none;
		}
	}
}
