using System;
namespace Game.View
{
	public interface IGameOverView
	{
		event EventHandler OnReStartGameClick;
		event EventHandler OnExitClick;
	}
}

