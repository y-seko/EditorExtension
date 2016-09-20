using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// ラベル
	/// </summary>
	public class Label : BaseView {
		public string title;
		public string text;

		public Label(string title, string text) {
			this.skin = ViewSkin.Label;
			this.title = title;
			this.text = text;
		}

		public Label () : this(null, null) {
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
