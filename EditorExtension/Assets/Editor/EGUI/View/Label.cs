using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// ラベル
	/// </summary>
	public class Label : BaseView {
		public string title;
		public string text;

		public Label(BaseView parent, string title, string text) : base(parent) {
			this.skin = ViewSkin.Label;
			this.title = title;
			this.text = text;
		}

		public Label (BaseView parent) : this(parent, null, null) {
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
