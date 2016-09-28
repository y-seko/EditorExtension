using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Slider.
	/// </summary>
	public class Slider : BaseView {

		// public fields.
		public string title;
		public float min;
		public float max;
		public float value;

		// private fields.
		List<ISliderEventReceiver> receivers;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.Slider"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		/// <param name="min">Minimum.</param>
		/// <param name="max">Max.</param>
		/// <param name="value">Value.</param>
		public Slider(BaseLayoutView parent, string title, float min, float max, float value)
			: base(parent) {
			this.style = ViewStyle.None;
			this.title = title;
			this.min = min;
			this.max = max;
			this.value = value;
			this.receivers = new List<ISliderEventReceiver> ();
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			float prev = value;
			value = EditorGUILayout.Slider (title, value, min, max, optionList.ToArray());
			if (prev != value) {
				foreach (ISliderEventReceiver receiver in receivers) {
					receiver.OnValueChanged (this);
				}
			}
		}

		/// <summary>
		/// Adds the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(ISliderEventReceiver receiver) {
			receivers.Add (receiver);
		}

		/// <summary>
		/// Removes the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void RemoveReceiver(ISliderEventReceiver receiver) {
			receivers.Remove (receiver);
		}
	}
}
