using System;
using System.Collections;
using UnityEngine;
using CX.Obj;

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
		isEnabled = true;
		nextTime = Time.time + Interval;
		Loop.UpdateEvent += Updating;
	}

	public virtual void Stop()
	{
		isEnabled = false;
		Loop.UpdateEvent -= Updating;
	}

	public virtual void Close()
	{
		Stop();
		Elapsed = null;
	}

	void Updating()
	{
		if (IsEnabled && Time.time > nextTime)
		{
			nextTime = Time.time + Interval;
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
		set { isEnabled = value; }
	}

	protected virtual void Count()
	{
		Elapsed(nowCount);
	}

	private bool isEnabled;
	protected int nowCount;
	private float nextTime;
}
