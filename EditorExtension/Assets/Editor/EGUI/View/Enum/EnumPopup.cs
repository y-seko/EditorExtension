using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Enum popup.
	/// </summary>
	public class EnumPopup : BaseView {

		public Enum value;

		List<IEnumPopupEventReceiver> receivers;
		bool isValueChanged;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.EnumPopup"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="value">Value.</param>
		public EnumPopup(BaseLayoutView parent, Enum value) : base(parent) {
			this.value = value;
			this.receivers = new List<IEnumPopupEventReceiver> ();
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			Enum prev = value;
			value = EditorGUILayout.EnumPopup ("enum", value);
			if (!prev.ToString().Equals(value.ToString())) {
				isValueChanged = true;
			}
		}

		/// <summary>
		/// Raises the update event.
		/// </summary>
		public override void OnUpdate () {
			if (isValueChanged) {
				foreach (IEnumPopupEventReceiver receiver in receivers) {
					receiver.OnValueChanged (this);
				}
				isValueChanged = false;
			}
		}

		/// <summary>
		/// Adds the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(IEnumPopupEventReceiver receiver) {
			receivers.Add (receiver);
		}

		/// <summary>
		/// Removes the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void RemoveReceiver(IEnumPopupEventReceiver receiver) {
			receivers.Remove (receiver);
		}
	}
}
