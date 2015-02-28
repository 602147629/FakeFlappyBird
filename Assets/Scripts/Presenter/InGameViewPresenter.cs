using CX.MVP.Presenter;
using UnityEngine.Events;

namespace Game.View
{
	public class InGameViewPresenter : NavPresenter<IInGameView>
	{
		public InGameViewPresenter ()
		{
			gameFlow = GameFacade.GameFlow;
		}

		protected override void InitializeView()
		{
			view.OnPauseEvent.AddListener(OnPause);
			SetPauseText();
		}

		private void OnPause()
		{
			isPause = !isPause;
			SetPauseText ();

			if (isPause) gameFlow.Pause();
			else gameFlow.Resume();
		}

		void SetPauseText ()
		{
			view.PauseBtnText = isPause ? "Resume" : "Pause";
		}

		bool isPause;
		IGameFlow gameFlow;
	}
}

