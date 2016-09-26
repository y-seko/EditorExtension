using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	public abstract class ListViewCell : BaseView {
		public virtual void CreateView (object item) {
		}
	}
}
