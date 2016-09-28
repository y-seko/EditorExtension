using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウトビュー
	/// </summary>
	public class VerticalLayoutView : BaseLayoutView {

		public VerticalLayoutView(BaseLayoutView parent) : base(parent) {
			this.style = ViewStyle.Box;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			EditorGUILayout.BeginVertical (style.GetGUIStyle(), optionList.ToArray());
			DrawChildren ();
			EditorGUILayout.EndVertical ();
		}
	}
}
