using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// ラベル
	/// </summary>
	public class Label : BaseView {
		public string title;
		public string text;

		public Label(string title, string text, ViewSkin skin, params GUILayoutOption[] options) : base(skin, options) {
			this.title = title;
			this.text = text;
		}

		public Label(string title, string text, params GUILayoutOption[] options) : this(title, text, ViewSkin.Label, options) {
		}

		public Label(string title, string text) : this(title, text, null) {
		}

		public Label () : this(null, null, null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			EditorGUILayout.LabelField (title, text, GetGUIStyle(), options);
			base.Draw ();
		}
	}
}
