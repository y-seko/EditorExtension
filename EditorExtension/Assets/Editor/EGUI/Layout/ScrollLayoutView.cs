using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// スクロール可能なレイアウトビュー
	/// </summary>
	public class ScrollLayoutView : BaseLayoutView {

		Vector2 scrollPosition;

		public ScrollLayoutView(BaseLayoutView parent) : base(parent) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			scrollPosition = EditorGUILayout.BeginScrollView (scrollPosition);
			DrawChildren ();
			EditorGUILayout.EndScrollView ();
		}
	}
}
