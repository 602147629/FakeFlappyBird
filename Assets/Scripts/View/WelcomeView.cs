using UnityEngine;
using UnityEngine.UI;
using Presenter;
using System;

namespace View
{
	public class WelcomeView : MonoView, IWelcomeView {

		public Button startGameBtn;

		void Awake()
		{
			startGameBtn.onClick = new Button.ButtonClickedEvent();
			startGameBtn.onClick.AddListener(delegate {
				if (OnStartGameClick != null)
					OnStartGameClick(this, EventArgs.Empty);
			});

			new WelcomePresenter(this);
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

