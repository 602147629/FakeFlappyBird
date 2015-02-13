using UnityEngine;
using CX.MVP.Presenter;

namespace Game.View
{
	public class GameOverViewPresenter : NavPresenter<IGameOverView>
	{
		protected override void InitializeView ()
		{
			view.OnReStartGameClick.AddListener(delegate {
				GameFacade.GameFlow.Resume();
				NavTo("InGameView");
			});
			view.OnExitClick.AddListener(delegate {
				GameFacade.GameFlow.Exit();
				NavTo("WelcomeView");
			});
		}
	}
}
