using UnityEngine;
using UnityEditor;

namespace EGUI {
	/// <summary>
	/// 水平方向のレイアウトを維持するクラス
	/// </summary>
	public class HorizontalLayout : Node {
		public override void Draw() {
			EditorGUILayout.BeginHorizontal ();
			base.Draw ();
			EditorGUILayout.EndHorizontal ();
		}
	}
}
