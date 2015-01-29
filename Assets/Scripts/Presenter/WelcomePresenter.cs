using UnityEngine;

namespace Game.View
{
	public class WelcomePresenter
	{
		IWelcomeView view;
		IGameFlow gameFlow;

		public WelcomePresenter (IWelcomeView view)
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
			view.OnStartGameClick += HandleOnStartGameClick;
		}

		void HandleOnStartGameClick (object sender, System.EventArgs e)
		{
			GameFlow.Start();
		}
	}
}
