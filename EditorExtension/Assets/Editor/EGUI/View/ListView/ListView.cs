using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {

	public class ListView<C, I> : BaseView where C : ListViewCell, new() {

		/// <summary>
		/// リストの向き
		/// </summary>
		public enum Direction {
			Vertical,
			Horizontal,
		}

		BaseView layout;
		List<ListViewCell> views = new List<ListViewCell> ();
		List<I> itemList;

		public ListView(BaseView parent, Direction direction) : base(parent) {
			if (direction == Direction.Vertical) {
				layout = new VerticalLayout (parent);
			}
			else {
				layout = new HorizontalLayout (parent);
			}
		}

		/// <summary>
		/// Sets the item list.
		/// </summary>
		/// <param name="itemList">Item list.</param>
		public void SetItemList(List<I> itemList) {
			this.itemList = itemList;

			foreach (I item in itemList) {
				C view = new C();
				view.CreateView (item);
				view.SetParent (layout);
				views.Add (view);
			}
		}

		/// <summary>
		/// Gets the item.
		/// </summary>
		/// <returns>The item.</returns>
		/// <param name="index">Index.</param>
		public I GetItem(int index) {
			return this.itemList [index];
		}
	}
}
