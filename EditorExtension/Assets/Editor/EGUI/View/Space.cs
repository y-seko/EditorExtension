using UnityEditor;
using System.Collections;

namespace EGUI {
	public class Space : BaseView {
		public Space(BaseView parent) : base(parent) {
		}

		public override void Draw() {
			EditorGUILayout.Space ();
			base.Draw ();
		}
	}
}
