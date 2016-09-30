using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Int field.
	/// </summary>
	public class IntField : BaseView {

		// public fields.
		public string title;
		public int value;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.IntField"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		/// <param name="value">Value.</param>
		public IntField(BaseLayoutView parent, string title, int value)
			: base(parent) {
			this.title = title;
			this.value = value;
		}

		public IntField(BaseLayoutView parent, int value)
			: this(parent, "", value) {
		}

		public IntField(BaseLayoutView parent)
			: this(parent, 0) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			value = EditorGUILayout.IntField (title, value);
		}
	}
}