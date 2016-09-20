using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// ウィンドウを表示するクラス
	/// </summary>
	public class Window : EditorWindow {

		public ScrollView view { get; private set; }

		public Window() {
			view = new ScrollView ();
		}

		/// <summary>
		/// 初期化
		/// </summary>
		public virtual void Init() {
		}

		public void AddChild(Node node) {
			view.AddChild (node);
		}

		void OnGUI() {
			if (view != null) {
				view.Draw ();
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
