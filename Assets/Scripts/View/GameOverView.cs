using UnityEngine;
using UnityEngine.UI;
using CX.U3D.MVP.View;
using System;

namespace Game.View
{
	public class GameOverView : U3DView, IGameOverView {

		public Button restartBtn;
		public Button exitBtn;

		GameOverViewPresenter gameOverPresnter;

		void Awake()
		{
			RegBtnEvent(restartBtn, OnReStartGameClick);
			RegBtnEvent(exitBtn, OnExitClick);
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

