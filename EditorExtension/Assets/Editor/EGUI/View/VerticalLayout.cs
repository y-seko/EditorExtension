using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 垂直方向のレイアウトを維持するクラス
	/// </summary>
	public class VerticalLayout : Node {
		public override void Draw() {
			EditorGUILayout.BeginVertical ();
			base.Draw ();
			EditorGUILayout.EndVertical ();
		}
	}
}
