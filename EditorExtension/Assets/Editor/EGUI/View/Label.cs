using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// ラベルを表示するクラス
	/// </summary>
	public class Label : Node {
		public string title;
		public string text;
		public GUILayoutOption[] options;

		public Label(string title, string text, params GUILayoutOption[] options) {
			this.title = title;
			this.text = text;
			this.options = options;
		}

		public Label(string title, string text) : this(title, text, null) {
		}

		public Label () : this(null, null, null) {
		}

		public override void Draw() {
			EditorGUILayout.LabelField (title, text, options);
			base.Draw ();
		}
	}
}
