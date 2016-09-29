using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Float slider.
	/// </summary>
	public class FloatSlider : Slider {

		// public fields.
		public float min;
		public float max;
		public float value;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.FloatSlider"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		/// <param name="min">Minimum.</param>
		/// <param name="max">Max.</param>
		/// <param name="value">Value.</param>
		public FloatSlider(BaseLayoutView parent, string title, float min, float max, float value)
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
			value = EditorGUILayout.Slider (title, value, min, max, optionList.ToArray());
			if (prev != value) {
				return true;
			}
			return false;
		}
	}
}
