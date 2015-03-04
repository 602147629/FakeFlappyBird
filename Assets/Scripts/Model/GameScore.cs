using Game;

public class GameScore
{
	private Timer timer;
	private ValueChage<int> scoreChange;

	private int score;
	private int Score
	{
		set 
		{
			scoreChange.Value = value;
			score = value;
		}
		get
		{
			return score;
		}
	}

	public GameScore()
	{
		IGameFlow gameFlow = GameFacade.GameFlow;
		scoreChange = new ValueChage<int>();
		timer = new Timer();
		timer.Elapsed += HandleElapsed;

		gameFlow.GameStart += (sender, e) => Start();
		gameFlow.GameStop += (sender, e) => Pause();
		gameFlow.GameResume += (sender, e) => Resume();
		gameFlow.GameRestart += (sender, e) => Restart();
		gameFlow.GamePause += (sender, e) => Pause();
		gameFlow.GameExit += (sender, e) => Stop();
	}

	void HandleElapsed (float nowCount)
	{
		Score ++;
	}

	public void Start()
	{
		Score = 0;
		timer.Start();
		scoreChange.AddListener(GameFacade.ViewMgr.GetView<Game.View.InGameView>().scoreChangeText);
	}

	public void Restart()
	{
		Score = 0;
		Resume();
	}

	public void Pause()
	{
		timer.IsEnabled = false;
	}

	public void Resume()
	{
		timer.IsEnabled = true;
	}

	public void Stop()
	{
		timer.Close();
		scoreChange.ClearListeners();
	}
}
