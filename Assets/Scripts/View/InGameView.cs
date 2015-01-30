using UnityEngine.UI;
using CX.U3D.MVP.View;

namespace Game.View
{
	public class InGameView : U3DView, IInGameView
	{
		public Button pauseBtn;
		private Text pausBtnText;

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
			get
			{
				return pausBtnText.text;
			}
			set
			{
				pausBtnText.text = value;
			}
		}
	}
}

