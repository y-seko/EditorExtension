using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {
	/// <summary>
	/// Node.
	/// </summary>
	public class Node {

		Node parent;
		protected List<Node> children;

		public Node() {
			children = new List<Node> ();
		}

		public Node(Node parent) : this() {
			SetParent (parent);
		}

		/// <summary>
		/// Sets the parent.
		/// </summary>
		/// <param name="parent">Parent.</param>
		public void SetParent(Node parent) {
			if (this.parent != null) {
				this.parent.RemoveChild (this);
				this.parent = null;
			}
			parent.AddChild (this);
			this.parent = parent;
		}

		/// <summary>
		/// Adds the child.
		/// </summary>
		/// <param name="child">Child.</param>
		public void AddChild(Node child) {
			child.parent = this;
			children.Add (child);
		}

		/// <summary>
		/// Removes the child.
		/// </summary>
		/// <param name="child">Child.</param>
		public void RemoveChild(Node child) {
			children.Remove (child);
			child.parent = null;
		}
	}
}
