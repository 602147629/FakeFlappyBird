using UnityEngine;
using CX.MVP.Presenter;

namespace Game.View
{
	public class WelcomeViewPresenter : NavPresenter<IWelcomeView>
	{
		protected override void InitializeView ()
		{
			view.OnStartGameEvent.AddListener(delegate {
				NavTo("GameOverView");				
			});
		}
	}
}
