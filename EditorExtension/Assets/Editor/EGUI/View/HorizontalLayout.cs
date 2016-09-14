using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウトを維持するクラス
	/// </summary>
	public class HorizontalLayout : BaseView {

		public HorizontalLayout(ViewSkin skin, params GUILayoutOption[] options) : base(skin, options) {
		}

		public HorizontalLayout(ViewSkin skin) : this(skin, null) {
		}

		public HorizontalLayout(params GUILayoutOption[] options) : this(ViewSkin.Box, options) {
		}

		public HorizontalLayout() : this(ViewSkin.Box, null) {
		}

		public override void Draw() {
			EditorGUILayout.BeginHorizontal (GetGUIStyle(), options);
			base.Draw ();
			EditorGUILayout.EndHorizontal ();
		}
	}
}
