using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Space.
	/// </summary>
	public class Space : BaseView {

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.Space"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		public Space(BaseLayoutView parent) : base(parent) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			EditorGUILayout.Space ();
		}
	}
}
