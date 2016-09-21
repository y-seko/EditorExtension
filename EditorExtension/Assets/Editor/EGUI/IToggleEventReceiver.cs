using UnityEngine;
using System.Collections;

namespace EGUI {
	public interface IToggleEventReceiver {
		void OnValueChanged(Toggle toggle);
	}
}
