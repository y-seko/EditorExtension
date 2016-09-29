using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Int slider.
	/// </summary>
	public class IntSlider : Slider {

		// public fields.
		public int min;
		public int max;
		public int value;

		public IntSlider(BaseLayoutView parent, string title, int min, int max, int value)
			: base(parent, title) {
			this.min = min;
			this.max = max;
			this.value = value;
		}

		/// <summary>
		/// Draws the slider.
		/// </summary>
		/// <returns>true</returns>
		/// <c>false</c>
		public override bool DrawSlider() {
			float prev = value;
			value = EditorGUILayout.IntSlider (title, value, min, max, optionList.ToArray());
			if (prev != value) {
				return true;
			}
			return false;
		}
	}
}
