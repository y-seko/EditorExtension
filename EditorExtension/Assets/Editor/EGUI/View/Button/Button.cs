using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Button.
	/// </summary>
	public class Button : BaseView {

		// public fields.
		public string text;

		// private fields.
		List<IButtonEventReceiver> receivers;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.Button"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="text">Text.</param>
		public Button(BaseLayoutView parent, string text)
			: base (parent) {
			this.style = ViewStyle.Button;
			this.text = text;
			this.receivers = new List<IButtonEventReceiver> ();
		}

		public Button(BaseLayoutView parent)
			: this(parent, "") {
		}

		public Button()
			: this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			if (GUILayout.Button (text, style.GetGUIStyle (), optionList.ToArray ())) {
				foreach (IButtonEventReceiver receiver in receivers) {
					receiver.OnClick (this);
				}
			}
		}

		/// <summary>
		/// Adds the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(IButtonEventReceiver receiver) {
			receivers.Add (receiver);
		}

		/// <summary>
		/// Removes the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void RemoveReceiver(IButtonEventReceiver receiver) {
			receivers.Remove (receiver);
		}
	}
}
