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
		public virtual void AddChild(Node child) {
			this.children.Add (child);
			child.parent = this;
		}
	}
}
