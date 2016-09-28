using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウトビュー
	/// </summary>
	public class HorizontalLayoutView : BaseLayoutView {

		public HorizontalLayoutView(BaseLayoutView parent) : base(parent) {
			this.style = ViewStyle.Box;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.BeginHorizontal (style.GetGUIStyle());
			DrawChildren ();
			EditorGUILayout.EndHorizontal ();
		}
	}
}
