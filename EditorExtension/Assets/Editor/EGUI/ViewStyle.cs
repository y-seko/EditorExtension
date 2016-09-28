﻿using UnityEngine;
using System.Collections;

namespace EGUI {
	/// <summary>
	/// View skin.
	/// </summary>
	public enum ViewStyle {
		None,
		Label,
		Box,
		TextField,
	}

	static class ViewStyleExtension {
		/// <summary>
		/// Gets the GUI style.
		/// </summary>
		/// <returns>The GUI style.</returns>
		/// <param name="skin">Skin.</param>
		public static GUIStyle GetGUIStyle(this ViewStyle skin) {
			switch (skin) {
			case ViewStyle.Box:
				return GUI.skin.box;
			case ViewStyle.Label:
				return GUI.skin.label;
			case ViewStyle.TextField:
				return GUI.skin.textField;
			default:
				return GUIStyle.none;
			}
		}
	}
}
