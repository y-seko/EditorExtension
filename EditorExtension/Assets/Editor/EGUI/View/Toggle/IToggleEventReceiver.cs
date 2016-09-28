namespace EGUI {
	public interface IToggleEventReceiver {
		/// <summary>
		/// Raises the value changed event.
		/// </summary>
		/// <param name="toggle">Toggle.</param>
		void OnValueChanged(Toggle toggle);
	}
}