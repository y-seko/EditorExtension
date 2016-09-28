using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウトビュー
	/// </summary>
	public class VerticalLayoutView : BaseLayoutView {

		public VerticalLayoutView(BaseLayoutView parent) : base(parent) {
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
