using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	public class ScrollView : BaseView {

		Vector2 scrollPosition = Vector2.zero;

		public ScrollView() : base () {
		}

		public override void Draw () {
			scrollPosition = EditorGUILayout.BeginScrollView (scrollPosition);
			base.Draw ();
			EditorGUILayout.EndScrollView ();
		}
	}
}