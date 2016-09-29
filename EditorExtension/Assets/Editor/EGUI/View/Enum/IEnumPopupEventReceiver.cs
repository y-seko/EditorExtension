namespace EGUI {
	/// <summary>
	/// Enum popup event receiver.
	/// </summary>
	public interface IEnumPopupEventReceiver {
		/// <summary>
		/// Raises the value changed event.
		/// </summary>
		/// <param name="popup">Popup.</param>
		void OnValueChanged (EnumPopup popup);
	}
}
