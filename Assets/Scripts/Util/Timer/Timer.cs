using System;
using System.Collections;
using UnityEngine;

public class Timer
{
	public Timer () : this (1)
	{
	}

	public Timer (float interval)
	{
		this.Interval = interval;
	}

	public float Interval
	{
		set; get;
	}

	public delegate void TimeElapsedEvent (float nowCount);
	public event TimeElapsedEvent Elapsed;

	public virtual void Start()
	{
		Counter.StopAllCoroutines();
		isEnabled = true;
		Counter.StartCoroutine(Counting());
	}

	public virtual void Stop()
	{
		isEnabled = false;
	}

	public virtual void Close()
	{
		isEnabled = false;
		if (_counter != null)
			GameObject.Destroy(_counter.gameObject);
		Elapsed = null;
		_counter = null;
	}

	IEnumerator Counting()
	{
		while (IsEnabled)
		{
			yield return new WaitForSeconds(Interval);
			if (Elapsed != null)
			{
				nowCount ++;
				Count();
			}
		}
	}

	public virtual bool IsEnabled
	{
		get { return isEnabled; }
	}

	protected virtual void Count()
	{
		Elapsed(nowCount);
	}

	private bool isEnabled;
	protected int nowCount;

	MonoBehaviour _counter;
	MonoBehaviour Counter
	{
		get
		{
			if (_counter == null)
				_counter = new GameObject().AddComponent<MonoBehaviour>();
			return _counter;
		}
	}
}
