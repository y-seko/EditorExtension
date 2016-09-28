using UnityEngine;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Base view.
	/// </summary>
	public class BaseView : Node {

		public BaseView(BaseLayoutView parent) : base(parent) {
		}

		public BaseView() : this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public virtual void OnDraw() {
		}
	}
}
