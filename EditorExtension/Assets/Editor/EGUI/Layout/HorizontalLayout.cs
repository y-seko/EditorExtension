using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウト
	/// </summary>
	public class HorizontalLayout : BaseLayout {

		public HorizontalLayout(BaseLayout parent) : base(parent) {
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
