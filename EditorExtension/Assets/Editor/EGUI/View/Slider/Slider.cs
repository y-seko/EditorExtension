using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Slider.
	/// </summary>
	public abstract class Slider : BaseView {

		// public fields.
		public string title;

		// private fields.
		List<ISliderEventReceiver> receivers;
		bool isValueChanged;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.Slider"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		public Slider(BaseLayoutView parent, string title)
			: base(parent) {
			this.style = ViewStyle.None;
			this.title = title;
			this.receivers = new List<ISliderEventReceiver> ();
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			isValueChanged = DrawSlider ();
		}

		/// <summary>
		/// Raises the update event.
		/// </summary>
		public override void OnUpdate () {
			if (isValueChanged) {
				foreach (ISliderEventReceiver receiver in receivers) {
					receiver.OnValueChanged (this);
				}
				isValueChanged = false;
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

		/// <summary>
		/// Draws the slider.
		/// </summary>
		/// <returns><c>true</c>, if slider was drawn, <c>false</c> otherwise.</returns>
		public abstract bool DrawSlider ();
	}
}
