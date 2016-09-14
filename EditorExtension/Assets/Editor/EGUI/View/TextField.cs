using UnityEngine;
using UnityEditor;

namespace EGUI {
	public class TextField : Node {
		public string title;
		public string text;
		public GUILayoutOption[] options;

		public TextField(string title, string text, params GUILayoutOption[] options) {
			this.title = title;
			this.text = text;
			this.options = options;
		}

		public TextField(string title, string text) : this(title, text, null) {
		}

		public TextField(string text) : this("", text, null) {
		}

		public override void Draw() {
			text = EditorGUILayout.TextField (title, text, options);
			base.Draw ();
		}
	}
}
