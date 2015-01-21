using Presenter;
using UnityEngine;

namespace Presenter
{
	public class GameOverPresenter
	{
		IGameOverView view;

		public GameOverPresenter (Presenter.IGameOverView view)
		{
			this.view = view;
			Init();
		}	

		void Init()
		{
			view.OnReStartGameClick += HandleOnReStartGameClick;
			view.OnExitClick += HandleOnExitClick;
		}

		void HandleOnReStartGameClick (object sender, System.EventArgs e)
		{
			
		}

		void HandleOnExitClick (object sender, System.EventArgs e)
		{
			Application.Quit();
		}
	}
}
