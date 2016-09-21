using UnityEngine;
using System.Collections;

namespace EGUI {
	public interface IButtonEventReceiver {
		void OnClick(Button button);
	}
}
