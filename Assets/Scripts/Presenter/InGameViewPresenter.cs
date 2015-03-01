using CX.MVP.Presenter;
using UnityEngine.Events;
using UnityEngine;
using System.Collections;
using System;

namespace Game.View
{
	public class InGameViewPresenter : NavPresenter<IInGameView>
	{
		public InGameViewPresenter ()
		{
			gameFlow = GameFacade.GameFlow;
			counter = new CountTimer(3);
			counter.Elapsed += HandleElapsed;
		}

		void HandleElapsed (float nowCount)
		{
			var ct = counter.TotalCount - nowCount + 1;
			SetCountDownText (ct.ToString());

			if (counter.TotalCount == nowCount)
			{
				SetCountDownText("");
				gameFlow.Resume();
			}
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
			else 
			{
				counter.Start();
			}
		}


		void SetPauseText ()
		{
			view.PauseBtnText = isPause ? "Resume" : "Pause";
		}

		void SetCountDownText(string countDownText)
		{
			View.CountDownText = countDownText;
		}

		bool isPause;
		IGameFlow gameFlow;
		CountTimer counter;
	}
}

