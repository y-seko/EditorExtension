using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Toggle.
	/// </summary>
	public class Toggle : BaseView {

		// public fields.
		public string title;
		public bool isCheck;

		// private fields.
		List<IToggleEventReceiver> receivers;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.Toggle"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="title">Title.</param>
		/// <param name="isCheck">If set to <c>true</c> is check.</param>
		public Toggle(BaseLayoutView parent, string title, bool isCheck)
			: base(parent) {
			this.style = ViewStyle.Toggle;
			this.title = title;
			this.isCheck = isCheck;
			this.receivers = new List<IToggleEventReceiver> ();
		}

		public Toggle(BaseLayoutView parent, string title)
			: this(parent, title, false) {
		}

		public Toggle(BaseLayoutView parent)
			: this(parent, "") {
		}

		public Toggle()
			: this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			bool prev = isCheck;
			isCheck = DrawToggle ();
			if (isCheck != prev) {
				foreach (IToggleEventReceiver receiver in receivers) {
					receiver.OnValueChanged (this);
				}
				GUIUtility.keyboardControl = 0;
			}
		}

		/// <summary>
		/// Adds the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(IToggleEventReceiver receiver) {
			receivers.Add (receiver);
		}

		/// <summary>
		/// Removes the receiver.
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void RemoveReceiver(IToggleEventReceiver receiver) {
			receivers.Remove (receiver);
		}

		/// <summary>
		/// Draws the toggle.
		/// </summary>
		/// <returns><c>true</c>, if toggle was drawn, <c>false</c> otherwise.</returns>
		public virtual bool DrawToggle() {
			return EditorGUILayout.Toggle (title, isCheck, style.GetGUIStyle (), optionList.ToArray ());
		}
	}
}
