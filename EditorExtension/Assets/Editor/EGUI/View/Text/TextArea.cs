using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Text area.
	/// </summary>
	public class TextArea : BaseView {

		// public fields.
		public string text;

		public TextArea(BaseLayoutView parent, string text)
			: base(parent) {
			this.style = ViewStyle.TextArea;
			this.text = text;
		}

		public TextArea(BaseLayoutView parent)
			: this(parent, "") {
		}

		public TextArea()
			: this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			text = EditorGUILayout.TextArea (text, style.GetGUIStyle (), optionList.ToArray ());
		}
	}
}
