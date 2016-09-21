using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;

namespace EGUI {
	public class Button : BaseView {
		public string text;
		public Action callback;
		public List<IButtonEventReceiver> receivers;

		public Button(BaseView parent, string text, Action OnClick) : base(parent) {
			this.text = text;
			this.callback = OnClick;
			this.receivers = new List<IButtonEventReceiver> ();
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void Draw() {
			if (GUILayout.Button (text, options)) {
				OnClick ();
			}
			base.Draw ();
		}

		/// <summary>
		/// イベントレシーバーを追加する
		/// </summary>
		/// <param name="receiver">Receiver.</param>
		public void AddReceiver(IButtonEventReceiver receiver) {
			this.receivers.Add (receiver);
		}

		/// <summary>
		/// ボタンクリック時の処理
		/// </summary>
		void OnClick() {
			if (callback != null) {
				callback ();
			}
			foreach (IButtonEventReceiver receiver in receivers) {
				receiver.OnClick (this);
			}

			GUIUtility.keyboardControl = 0;
		}
	}
}
