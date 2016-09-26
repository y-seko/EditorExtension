using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// 親子関係を持つクラス
	/// </summary>
	public class Node {
		public Node parent;
		public List<Node> children;

		public Node() {
			children = new List<Node> ();
		}

		/// <summary>
		/// 子を追加する
		/// </summary>
		/// <param name="child">Child.</param>
		public void AddChild(Node child) {
			this.children.Add (child);
			child.parent = this;
		}

		/// <summary>
		/// 子を外す
		/// </summary>
		/// <param name="child">Child.</param>
		public void RemoveChild(Node child) {
			this.children.Remove (child);
			child.parent = null;
		}

		/// <summary>
		/// 親を設定する
		/// </summary>
		/// <param name="parent">Parent.</param>
		public void SetParent(Node parent) {
			if (this.parent != null) {
				this.parent.RemoveChild (this);
			}
			parent.AddChild (this);
		}
	}
}
