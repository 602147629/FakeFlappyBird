using System;
using UnityEngine.UI;

namespace Game.View
{
	public interface IWelcomeView
	{
		Button.ButtonClickedEvent OnStartGameEvent { get; }

	}
}

