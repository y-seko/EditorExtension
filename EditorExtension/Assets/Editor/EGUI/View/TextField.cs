using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// テキストフィールド.
	/// </summary>
	public class TextField : BaseView {
		public string title;
		public string text;

		public TextField(string title, string text, ViewSkin skin, params GUILayoutOption[] options) : base(skin, options){
			this.title = title;
			this.text = text;
		}

		public TextField(string title, string text, params GUILayoutOption[] options) : this(title, text, ViewSkin.TextField, options) {
		}

		public TextField(string title, string text) : this(title, text, ViewSkin.TextField, null) {
		}

		public TextField(string text) : this("", text, ViewSkin.TextField, null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			text = EditorGUILayout.TextField (title, text, GetGUIStyle(), options);
			base.Draw ();
		}
	}
}
