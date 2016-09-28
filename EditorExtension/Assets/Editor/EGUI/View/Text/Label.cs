using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	public class Label : BaseView {

		string title;
		string text;

		public Label(BaseLayoutView parent, string title, string text)
			: base(parent) {
			this.style = ViewStyle.Label;
			this.title = title;
			this.text = text;
		}

		public Label(BaseLayoutView parent, string title)
			: this(parent, title, "") {
		}

		public Label(BaseLayoutView parent)
			: this(parent, "", "") {
		}

		public Label()
			: this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.LabelField (title, text, style.GetGUIStyle(), optionList.ToArray());
		}
	}
}
