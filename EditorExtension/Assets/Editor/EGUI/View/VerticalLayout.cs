using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウトを維持するクラス
	/// </summary>
	public class VerticalLayout : BaseView {

		public VerticalLayout() {
			skin = ViewSkin.Box;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			EditorGUILayout.BeginVertical (GetGUIStyle(), options);
			base.Draw ();
			EditorGUILayout.EndVertical ();
		}
	}
}
