using UnityEngine;
using System.Collections.Generic;

public class TimerLoop : MonoBehaviour
{
	void Awake()
	{

	}

	void Update()
	{
		for (int i = 0; i < timerList.Count; i ++)
		{

		}
	}

	public void AddTimer(Timer timer)
	{
		timerList.Add(timer);
	}

	public void RemoveTimer(Timer timer)
	{
		timerList.Remove(timer);
	}

	IList<Timer> timerList = new List<Timer>();
}
