using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	public class Button : BaseView {

		string text;
		List<IButtonEventReceiver> receivers;

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
