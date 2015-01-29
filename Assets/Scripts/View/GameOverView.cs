using UnityEngine;
using UnityEngine.UI;
using Game.View;
using CX.U3D.MVP.View;
using System;

namespace View
{
	public class GameOverView : MonoView, IGameOverView {

		public Button restartBtn;
		public Button exitBtn;

		GameOverPresenter gameOverPresnter;

		void Awake()
		{
			RegBtnEvent(restartBtn, OnReStartGameClick);
			RegBtnEvent(exitBtn, OnExitClick);

			gameOverPresnter = new GameOverPresenter(this);
			gameOverPresnter.GameFlow = new GameFlowController();
		}

		void RegBtnEvent(Button btn, EventHandler eventHandler)
		{
			RegBtnEvent(btn, eventHandler, this, EventArgs.Empty);
		}

		void RegBtnEvent(Button btn, EventHandler eventHandler, object sender, EventArgs e)
		{
			btn.onClick = new Button.ButtonClickedEvent();
			btn.onClick.AddListener(delegate() {
				if (eventHandler != null)
					eventHandler(sender, e);
			});
		}

		public event EventHandler OnReStartGameClick;

		public event EventHandler OnExitClick;
	}
}

