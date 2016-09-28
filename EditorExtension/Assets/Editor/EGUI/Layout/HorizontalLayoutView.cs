using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウトビュー
	/// </summary>
	public class HorizontalLayoutView : BaseLayoutView {

		public HorizontalLayoutView(BaseLayoutView parent) : base(parent) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.BeginHorizontal ();
			DrawChildren ();
			EditorGUILayout.EndHorizontal ();
		}
	}
}
