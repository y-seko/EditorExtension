namespace EGUI {
	/// <summary>
	/// Slider event receiver.
	/// </summary>
	public interface ISliderEventReceiver {
		/// <summary>
		/// Raises the value changed event.
		/// </summary>
		/// <param name="slider">Slider.</param>
		void OnValueChanged (Slider slider);
	}
}
