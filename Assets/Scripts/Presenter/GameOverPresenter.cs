using UnityEngine;
namespace Game.View
{
	public class GameOverPresenter
	{
		IGameOverView view;
		IGameFlow gameFlow;

		public GameOverPresenter (IGameOverView view)
		{
			this.view = view;
			Init();
		}	

		public IGameFlow GameFlow {
			get {
				return gameFlow;
			}
			set {
				gameFlow = value;
			}
		}

		void Init()
		{
			view.OnReStartGameClick += HandleOnReStartGameClick;
			view.OnExitClick += HandleOnExitClick;
		}

		void HandleOnReStartGameClick (object sender, System.EventArgs e)
		{
			GameFlow.Restart();
		}

		void HandleOnExitClick (object sender, System.EventArgs e)
		{
			GameFlow.Stop();
		}
	}
}
