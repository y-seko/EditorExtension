using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Base view.
	/// </summary>
	public abstract class BaseView : Node {

		public ViewStyle style = ViewStyle.None;
		public bool active;

		protected List<GUILayoutOption> optionList;

		public BaseView(BaseLayoutView parent) : base(parent) {
			active = true;
			optionList = new List<GUILayoutOption> ();
		}

		public BaseView() : this(null) {
		}

		/// <summary>
		/// 描画
		/// </summary>
		public abstract void OnDraw();

		/// <summary>
		/// Raises the update event.
		/// </summary>
		public virtual void OnUpdate () {
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
