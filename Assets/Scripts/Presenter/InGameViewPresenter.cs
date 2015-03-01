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
				Coroutine.StartCoroutine(CountDown(3, 1, CountingAction));
			}
		}

		private void CountingAction(int count, int totalCount)
		{
			SetCountDownText ((totalCount - count).ToString());
			if (totalCount == count + 1)
			{
				SetCountDownText("");
				gameFlow.Resume();
			}
		}

		IEnumerator CountDown(int totalCount, int count, Action<int, int> act)
		{
			for(int i = 0; i < totalCount; i ++)
			{
				act(i, totalCount);
				yield return new WaitForSeconds(count);
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

		MonoBehaviour coroutine;
		MonoBehaviour Coroutine
		{
			get
			{
				if (coroutine == null)
					coroutine = new GameObject().AddComponent<MonoBehaviour>();
				return coroutine;
			}
		}
	}
}

