using System;
namespace Presenter
{
	public interface IGameOverView
	{
		event EventHandler OnReStartGameClick;
		event EventHandler OnExitClick;
	}
}

