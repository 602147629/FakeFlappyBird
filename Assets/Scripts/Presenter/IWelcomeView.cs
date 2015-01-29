using System;
using UnityEngine.UI;

namespace Game.View
{
	public interface IWelcomeView
	{
		event EventHandler OnStartGameClick;
		Button.ButtonClickedEvent OnStartGameEvent { get; }

	}
}

