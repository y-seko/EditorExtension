using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	public class Label : BaseView {

		string title;
		string text;

		public Label(BaseLayout parent, string title, string text)
			: base(parent) {
			this.title = title;
			this.text = text;
		}

		public Label(BaseLayout parent, string text)
			: this(parent, "", text) {
		}

		public Label(BaseLayout parent)
			: this(parent, "", "") {
		}

		public Label()
			: this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.LabelField (title, text);
		}
	}
}
