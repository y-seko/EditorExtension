using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	public class Toggle : Node {

		public bool isOn;
		public bool isLeft;
		public GUILayoutOption[] options;

		public override void Draw() {
			if (isLeft) {
				isOn = EditorGUILayout.ToggleLeft ("toggle", isOn, options);
			}
			else {
				isOn = EditorGUILayout.Toggle ("toggle", isOn, options);
			}
			base.Draw ();
		}
	}
}
