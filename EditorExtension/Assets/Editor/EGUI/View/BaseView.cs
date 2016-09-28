using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Base view.
	/// </summary>
	public class BaseView : Node {

		public ViewStyle style = ViewStyle.None;
		protected List<GUILayoutOption> optionList;

		public BaseView(BaseLayoutView parent) : base(parent) {
			optionList = new List<GUILayoutOption> ();
		}

		public BaseView() : this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public virtual void OnDraw() {
		}

		/// <summary>
		/// Adds the options.
		/// </summary>
		/// <param name="options">Options.</param>
		public void AddOptions(params GUILayoutOption[] options) {
			optionList.AddRange (options);
		}
	}
}
