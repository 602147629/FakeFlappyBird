using UnityEngine;
using UnityEngine.UI;
using System;
using Game.View;
using CX.U3D.MVP.View;

namespace View
{
	public class WelcomeView : MonoView, IWelcomeView {

		public Button startGameBtn;
		WelcomePresenter welcomePresenter;

		void Awake()
		{
			startGameBtn.onClick = new Button.ButtonClickedEvent();
			startGameBtn.onClick.AddListener(delegate {
				if (OnStartGameClick != null)
					OnStartGameClick(this, EventArgs.Empty);
			});

			welcomePresenter = new WelcomePresenter(this);
			welcomePresenter.GameFlow = new GameFlowController();
		}

		public event System.EventHandler OnStartGameClick;
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}

