using System;
using System.Collections.Generic;

[Serializable]
public class GameScoreList
{
	private const int MAX_COUNT = 20;
	private List<int> scoreList;

	public List<int> ScoreList {
		get {
			return scoreList;
		}
	}

	public GameScoreList ()
	{
		scoreList = new List<int>(MAX_COUNT + 1);
	}

	public void AddScore(int score)
	{
		scoreList.Add(score);
		scoreList.Sort((x,y) => {
			if (x == y) return 0;
			else if (x > y) return -1;
			else return 1;
		});

		if (scoreList.Count > 20)
			scoreList.RemoveAt(scoreList.Count - 1);
	}
}


