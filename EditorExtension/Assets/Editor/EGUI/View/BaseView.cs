using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace EGUI {

	public enum ViewSkin {
		None,
		Box,
		Label,
		TextField,
		Toggle,
		ToggleLeft,
	}

	public struct Size {
		public int width;
		public int height;

		public Size(int width, int height) {
			this.width = width;
			this.height = height;
		}
	}

	/// <summary>
	/// 基底クラス
	/// </summary>
	public class BaseView : Node {
		public ViewSkin skin = ViewSkin.None;
		public Size size;

		private GUILayoutOption[] _options;
		public GUILayoutOption[] options {
			get {
				return GetOptions();
			}
			set {
				_options = value;
			}
		}

		public BaseView(BaseView parent) {
			if (parent != null) {
				parent.AddView (this);
			}
		}

		public BaseView() {
		}

		/// <summary>
		/// GUIStyleを取得する.
		/// </summary>
		/// <returns>The GUI style.</returns>
		protected GUIStyle GetGUIStyle() {
			switch (skin) {
			case ViewSkin.Box:
				return GUI.skin.box;
			case ViewSkin.Label:
				return GUI.skin.label;
			case ViewSkin.TextField:
				return GUI.skin.textField;
			case ViewSkin.Toggle:
				return GUI.skin.toggle;
			case ViewSkin.ToggleLeft:
				return GUI.skin.label;
			}
			return GUIStyle.none;
		}

		/// <summary>
		/// 描画
		/// </summary>
		public virtual void Draw () {
			foreach (BaseView child in children) {
				child.Draw ();
			}
		}

		/// <summary>
		/// ビューを追加する
		/// </summary>
		/// <param name="view">View.</param>
		public void AddView(BaseView view) {
			AddChild (view);
		}

		/// <summary>
		/// オプションを取得する
		/// </summary>
		/// <returns>The options.</returns>
		private GUILayoutOption[] GetOptions() {
			if (size.width != 0 || size.height != 0) {
				List<GUILayoutOption> list = new List<GUILayoutOption>();
				if (_options != null) {
					foreach (GUILayoutOption option in _options) {
						list.Add (option);
					}
				}
				if (size.width > 0) {
					list.Add (GUILayout.Width (size.width));
				}
				if (size.height > 0) {
					list.Add (GUILayout.Height (size.height));
				}
				return list.ToArray ();
			}
			return null;
		}
	}
}
