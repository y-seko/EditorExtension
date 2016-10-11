using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {

	/// <summary>
	/// Direction.
	/// </summary>
	public enum Direction {
		Vertical,
		Horizontal,
	}

	/// <summary>
	/// List view.
	/// </summary>
	public abstract class ListView<T> : BaseLayoutView {

		public Direction direction = Direction.Vertical;

		/// <summary>
		/// Initializes a new instance of the <see cref="EGUI.ListView`1"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="direction">Direction.</param>
		public ListView(BaseLayoutView parent, Direction direction)
			: base(parent) {
			this.direction = direction;
			this.style = ViewStyle.Box;
		}

		/// <summary>
		/// Sets the item list.
		/// </summary>
		/// <param name="itemList">Item list.</param>
		public void SetItemList(List<T> itemList) {
			foreach (T item in itemList) {
				CreateCell (item);
			}
		}

		/// <summary>
		/// 描画
		/// </summary>
		public override void OnDraw () {
			if (direction == Direction.Vertical) {
				EditorGUILayout.BeginVertical (style.GetGUIStyle(), optionList.ToArray());
				DrawChildren ();
				EditorGUILayout.EndVertical ();
			}
			else if (direction == Direction.Horizontal) {
				EditorGUILayout.BeginHorizontal (style.GetGUIStyle(), optionList.ToArray());
				DrawChildren ();
				EditorGUILayout.EndHorizontal ();
			}
		}

		/// <summary>
		/// Creates the cell.
		/// </summary>
		/// <param name="item">Item.</param>
		public abstract void CreateCell (T item);
	}
}
