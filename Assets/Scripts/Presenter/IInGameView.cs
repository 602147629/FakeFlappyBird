using UnityEngine.UI;

namespace Game.View
{
	public interface IInGameView
	{
		Button.ButtonClickedEvent OnPauseEvent { get; }
		string PauseBtnText { set; }
		string CountDownText { set; }
		bool PasuBtnInterAct { set; }
	}
}

