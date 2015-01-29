using UnityEngine;
using UnityEngine.UI;
using System;
using CX.U3D.MVP.View;

namespace Game.View
{
	public class WelcomeView : U3DView, IWelcomeView {

		public Button startGameBtn;

		void Awake()
		{
			startGameBtn.onClick = new Button.ButtonClickedEvent();
		}

		public event System.EventHandler OnStartGameClick;	

		public Button.ButtonClickedEvent OnStartGameEvent
		{
			get
			{
				return startGameBtn.onClick;
			}
		}
	}
}

