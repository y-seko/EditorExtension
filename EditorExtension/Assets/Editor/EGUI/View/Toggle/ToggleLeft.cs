using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Toggle left.
	/// </summary>
	public class ToggleLeft : Toggle {

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.ToggleLeft"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		/// <param name="isCheck">If set to <c>true</c> is check.</param>
		public ToggleLeft(BaseLayoutView parent, string title, bool isCheck)
			: base(parent, title, isCheck) {
			this.style = ViewStyle.ToggleLeft;
		}

		public ToggleLeft(BaseLayoutView parent, string title)
			: this(parent, title, false) {
		}

		public ToggleLeft(BaseLayoutView parent)
			: this(parent, "") {
		}

		public ToggleLeft()
			: this(null) {
		}

		/// <summary>
		/// Draws the toggle.
		/// </summary>
		/// <returns>true</returns>
		/// <c>false</c>
		public override bool DrawToggle() {
			return EditorGUILayout.ToggleLeft (title, isCheck, style.GetGUIStyle (), optionList.ToArray ());
		}
	}
}
