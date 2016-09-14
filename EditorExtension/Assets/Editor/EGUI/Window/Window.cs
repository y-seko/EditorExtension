using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// ウィンドウを表示するクラス
	/// </summary>
	public class Window : EditorWindow {

		private Node parent = new Node ();

		/// <summary>
		/// 初期化
		/// </summary>
		public virtual void Init() {
		}

		public void AddChild(Node node) {
			parent.AddChild (node);
		}

		void OnGUI() {
			if (parent != null) {
				parent.Draw ();
			}
		}

		void OnEnable() {
			Debug.Log ("OnEnable");
			Init ();
		}

		void OnDestory() {
			Debug.Log ("OnDestory");
		}

		void OnFocus() {
//			Debug.Log ("OnFocus");
		}

		void OnLostFocus() {
//			Debug.Log ("OnLostFocus");
		}

		void OnSelectionChange() {
//			Debug.Log ("OnSelectionChange");
		}
	}
}
