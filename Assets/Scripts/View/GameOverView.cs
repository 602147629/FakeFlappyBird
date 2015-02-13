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
			restartBtn.onClick = new Button.ButtonClickedEvent();
			exitBtn.onClick = new Button.ButtonClickedEvent();
		}

		public Button.ButtonClickedEvent OnReStartGameClick
		{
			get
			{
				return restartBtn.onClick;
			}
		}

		public Button.ButtonClickedEvent OnExitClick
		{
			get
			{
				return exitBtn.onClick;
			}
		}
	}
}

