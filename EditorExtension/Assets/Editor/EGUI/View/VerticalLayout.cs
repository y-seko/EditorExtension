using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウトを維持するクラス
	/// </summary>
	public class VerticalLayout : BaseView {

		public VerticalLayout(ViewSkin skin, params GUILayoutOption[] options) : base(skin, options) {
		}

		public VerticalLayout(ViewSkin skin) : this(skin, null) {
		}

		public VerticalLayout(params GUILayoutOption[] options) : this(ViewSkin.Box, options) {
		}

		public VerticalLayout() : this(ViewSkin.Box, null) {
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
