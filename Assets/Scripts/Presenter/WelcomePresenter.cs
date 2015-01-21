using Presenter;
using UnityEngine;

namespace Presenter
{
	public class WelcomePresenter
	{
		IWelcomeView view;

		public WelcomePresenter (Presenter.IWelcomeView view)
		{
			this.view = view;
			Init();
		}	

		void Init()
		{
			view.OnStartGameClick += HandleOnStartGameClick;
		}

		void HandleOnStartGameClick (object sender, System.EventArgs e)
		{
			Application.LoadLevel("Level");
		}
	}
}
