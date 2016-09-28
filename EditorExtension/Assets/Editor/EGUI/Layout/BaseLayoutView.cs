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
		/// 子ビューの描画
		/// </summary>
		public void DrawChildren() {
			foreach (Node child in children) {
				((BaseView)child).OnDraw ();
			}
		}
	}
}
