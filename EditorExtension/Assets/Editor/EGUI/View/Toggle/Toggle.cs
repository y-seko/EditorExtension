using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// トグルボタン
	/// </summary>
	public class Toggle : BaseView {
		public string title;
		public bool isOn = false;
		public Action<bool> callback;
		public List<IToggleEventReceiver> receivers;

		public RectOffset margin;

		public Toggle (BaseView parent, string title, bool isOn, Action<bool> OnValueChanged)
			: base(parent) {
			this.skin = ViewSkin.Toggle;
			this.title = title;
			this.isOn = isOn;
			this.receivers = new List<IToggleEventReceiver> ();
			this.callback = OnValueChanged;
		}

		public Toggle (BaseView parent, string title, Action<bool> OnValueChanged)
			: this(parent, title, false, OnValueChanged) {
		}

		public Toggle (BaseView parent, string title) : this (parent, title, false, null) {
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
			if (callback != null) {
				callback (isOn);
			}

			foreach (IToggleEventReceiver receiver in receivers) {
				receiver.OnValueChanged (this);
			}

			GUIUtility.keyboardControl = 0;
		}
	}
}
