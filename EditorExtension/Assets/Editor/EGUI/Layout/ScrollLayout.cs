using UnityEngine;
using UnityEditor;

namespace EGUI {
	public class ScrollLayout : BaseLayout {

		Vector2 scrollPosition;

		public ScrollLayout(BaseLayout parent) : base(parent) {
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
