using UnityEngine;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Base layout.
	/// </summary>
	public class BaseLayoutView : BaseView {

		public BaseLayoutView(BaseLayoutView parent) : base(parent) {
		}

		public BaseLayoutView() : this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw() {
			DrawChildren ();
		}

		/// <summary>
		/// Raises the update event.
		/// </summary>
		public override void OnUpdate () {
			UpdateChildren ();
		}

		/// <summary>
		/// 子ビューの描画
		/// </summary>
		public void DrawChildren() {
			foreach (Node child in children) {
				BaseView view = (BaseView)child;
				if (view.active) {
					view.OnDraw ();
				}
			}
		}

		public void UpdateChildren() {
			foreach (Node child in children) {
				BaseView view = (BaseView)child;
				if (view.active) {
					view.OnUpdate ();
				}
			}
		}
	}
}
