using System;
using UnityEngine.UI;

namespace Game.View
{
	public interface IGameOverView
	{
		Button.ButtonClickedEvent OnReStartGameClick { get; }
		Button.ButtonClickedEvent OnExitClick { get; }
	}
}

