using UnityEngine;
using CX.MVP.Presenter;

namespace Game.View
{
	public class WelcomeViewPresenter : NavPresenter<IWelcomeView>
	{
		private IGameFlow gameFlow;

		public WelcomeViewPresenter()
		{
			gameFlow = GameFacade.GameFlow;
		}

		protected override void InitializeView ()
		{
			view.OnStartGameEvent.AddListener(delegate {
				NavTo("InGameView");
				gameFlow.Start();
			});
		}
	}
}
