using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// テキストフィールド.
	/// </summary>
	public class TextField : BaseView {
		public string title;
		public string text;

		public TextField(BaseView parent, string title, string text) : base(parent) {
			this.skin = ViewSkin.TextField;
			this.title = title;
			this.text = text;
		}

		public TextField(BaseView parent, string text) : this(parent, "", text) {
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
