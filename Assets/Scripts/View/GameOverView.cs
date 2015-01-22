using UnityEngine;
using UnityEngine.UI;
using Presenter;
using System;

namespace View
{
	public class GameOverView : MonoView, IGameOverView {

		public Button restartBtn;
		public Button exitBtn;

		void Awake()
		{
			RegBtnEvent(restartBtn, OnReStartGameClick);
			RegBtnEvent(exitBtn, OnExitClick);

			new GameOverPresenter(this);
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

