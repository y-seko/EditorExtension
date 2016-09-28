namespace EGUI {
	public interface IButtonEventReceiver {
		/// <summary>
		/// Raises the click event.
		/// </summary>
		/// <param name="button">Button.</param>
		void OnClick(Button button);
	}
}
