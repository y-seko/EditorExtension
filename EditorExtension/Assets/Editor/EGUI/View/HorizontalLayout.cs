using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウトを維持するクラス
	/// </summary>
	public class HorizontalLayout : BaseView {

		public HorizontalLayout(BaseView parent) : base(parent) {
			skin = ViewSkin.Box;
		}

		public override void Draw() {
			EditorGUILayout.BeginHorizontal (GetGUIStyle(), options);
			base.Draw ();
			EditorGUILayout.EndHorizontal ();
		}
	}
}
