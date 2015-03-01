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
			counter.FinalCount += HandleFinalCount;
			counter.TimerInit += HandleTimerInit;
		}

		void HandleTimerInit (float nowCount)
		{
			view.PasuBtnInterAct = false;
			SetCountDownText("3");
        }

		void HandleFinalCount (float nowCount)
		{
			SetCountDownText("");
			gameFlow.Resume();
			view.PasuBtnInterAct = true;
            SetPauseText(false);
		}

		void HandleElapsed (float nowCount)
		{
			var ct = counter.TotalCount - nowCount;
			SetCountDownText (ct.ToString());
		}

		protected override void InitializeView()
		{
			view.OnPauseEvent.AddListener(OnPause);
			SetPauseText(false);
		}

		private void OnPause()
		{
			isPause = !isPause;

			if (isPause) 
			{
				gameFlow.Pause();
				SetPauseText (true);
			}
			else 
			{

				counter.Start();
			}
		}


		void SetPauseText (bool isPause)
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

