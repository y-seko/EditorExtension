using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// Window.
	/// </summary>
	public class Window : EditorWindow {

		public ScrollLayoutView view = new ScrollLayoutView(null);

		/// <summary>
		/// ウィンドウが有効になった時に呼ばれる
		/// </summary>
		void OnEnable() {
			// ビューの作成
			OnCreateView ();
		}

		/// <summary>
		/// 描画
		/// </summary>
		void OnGUI() {
			view.OnDraw ();
		}

		/// <summary>
		/// Update this instance.
		/// </summary>
		void Update() {
			view.OnUpdate ();
		}

		/// <summary>
		/// ビューの作成
		/// </summary>
		public virtual void OnCreateView() {
		}

		/// <summary>
		/// ビューを追加する
		/// </summary>
		/// <param name="view">View.</param>
		public void AddView(BaseView view) {
			view.AddChild (view);
		}

		/// <summary>
		/// ビューを削除する
		/// </summary>
		/// <param name="view">View.</param>
		public void RemoveView(BaseView view) {
			view.RemoveChild (view);
		}
	}
}
