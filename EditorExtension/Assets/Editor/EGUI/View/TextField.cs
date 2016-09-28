using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	public class TextField : BaseView {

		string title;
		public string text;

		public TextField(BaseLayoutView parent, string title, string text)
			: base(parent) {
			this.style = ViewStyle.TextField;
			this.title = title;
			this.text = text;
		}

		public TextField(BaseLayoutView parent, string title)
			: this(parent, title, "") {
		}

		public TextField(BaseLayoutView parent)
			: this(parent, "") {
		}

		public TextField()
			: this(null) {
		}

		public override void OnDraw () {
			text = EditorGUILayout.TextField (title, text, style.GetGUIStyle (), optionList.ToArray ());
		}
	}
}
