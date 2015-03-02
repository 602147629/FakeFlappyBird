using UnityEngine.UI;
using CX.U3D.MVP.View;

namespace Game.View
{
	public class InGameView : U3DView, IInGameView
	{
		public Button pauseBtn;
		private Text pausBtnText;
		public Text countDownText;
		public TextChangeView lifeChangeText;
		public TextChangeView scoreChangeText;

		void Awake()
		{
			pauseBtn.onClick = new Button.ButtonClickedEvent();
			pausBtnText = pauseBtn.GetComponentInChildren<Text>();
		}

		public Button.ButtonClickedEvent OnPauseEvent
		{
			get
			{
				return pauseBtn.onClick;
			}
		}

		public string PauseBtnText
		{
			set
			{
				pausBtnText.text = value;
			}
		}

		public string CountDownText
		{
			set
			{
				countDownText.text = value;
			}
		}

		public bool PasuBtnInterAct
		{
			set
			{
				pauseBtn.interactable = value;
			}
		}
	}
}

