using UnityEngine;
using CX.MVP.Presenter;

namespace Game.View
{
	public class GameOverPresenter : NavPresenter<IGameOverView>
	{
		void Init()
		{
			view.OnReStartGameClick += HandleOnReStartGameClick;
			view.OnExitClick += HandleOnExitClick;
		}

		void HandleOnReStartGameClick (object sender, System.EventArgs e)
		{
		}

		void HandleOnExitClick (object sender, System.EventArgs e)
		{
		}
	}
}
