using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウト
	/// </summary>
	public class VerticalLayout : BaseLayout {

		public VerticalLayout(BaseLayout parent) : base(parent) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.BeginVertical ();
			DrawChildren ();
			EditorGUILayout.EndVertical ();
		}
	}
}
