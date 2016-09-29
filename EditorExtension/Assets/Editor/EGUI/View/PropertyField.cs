using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Property field.
	/// </summary>
	public class PropertyField : BaseView {

		// public fields.
		public SerializedProperty property;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.PropertyField"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="property">Property.</param>
		public PropertyField(BaseLayoutView parent, SerializedProperty property) : base(parent) {
			this.property = property;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			EditorGUILayout.PropertyField (property);
		}
	}
}
