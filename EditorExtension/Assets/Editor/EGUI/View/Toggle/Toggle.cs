using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// トグルボタン
	/// </summary>
	public class Toggle : BaseView {
		public string title;
		public bool isOn = false;
		public List<IToggleEventReceiver> receivers;

		public Toggle (BaseView parent, string title, bool isOn) : base(parent) {
			this.skin = ViewSkin.Toggle;
			this.title = title;
			this.isOn = isOn;
			this.receivers = new List<IToggleEventReceiver> ();
		}

		public Toggle (BaseView parent, string title) : this (parent, title, false) {
		}

		/// <summary>
		/// トグルを描画する
		/// </summary>
		/// <returns><c>true</c>, if toggle was drawn, <c>false</c> otherwise.</returns>
		protected virtual bool DrawToggle() {
			return EditorGUILayout.Toggle (title, isOn, GetGUIStyle(), options);;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			bool prev = isOn;
			isOn = DrawToggle ();
			if (isOn != prev) {
				OnValueChanged ();
			}
			base.Draw ();
		}

		/// <summary>
		/// イベントレシーバーを追加する
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(IToggleEventReceiver receiver) {
			this.receivers.Add (receiver);
		}

		/// <summary>
		/// 値が変更された時に呼ばれるコールバック
		/// </summary>
		protected void OnValueChanged() {
			foreach (IToggleEventReceiver receiver in receivers) {
				receiver.OnValueChanged (this);
			}
		}
	}
}
