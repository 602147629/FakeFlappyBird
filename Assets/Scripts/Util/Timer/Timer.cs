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
		Counter.StartCoroutine(Counting());
	}

	public virtual void Stop()
	{
		isEnabled = false;
		Counter.StopAllCoroutines();
	}

	public virtual void Close()
	{
		Stop();
		Elapsed = null;
		if (_counter != null)
		{
			//GameObject.Destroy(_counter.gameObject);
			counterPools.PutBack(_counter);
			_counter = null;
		}
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
			{
				_counter = counterPools.GetOne();
			}
			return _counter;
		}
	}

	static IObjectPool<MonoBehaviour> counterPools = new ObjectPool<MonoBehaviour>(new PooledMono(), 35);

	class PooledMono : IPooledObject<MonoBehaviour>
	{
		public MonoBehaviour Make()
		{
			var gameObject = new GameObject ("I am a timer");
			gameObject.AddComponent<DontDestroy>();
			var monoBehaviour = gameObject.AddComponent<MonoBehaviour> ();
			return monoBehaviour;
		}

		public void Activate(MonoBehaviour obj)
		{
			obj.gameObject.SetActive(true);
		}

		public void InAactivate(MonoBehaviour obj)
		{
			obj.gameObject.SetActive(false);
		}

		public void Destroy(MonoBehaviour obj)
		{
			GameObject.Destroy(obj.gameObject);
		}

		public bool Validate(MonoBehaviour obj)
		{
			return true;
		}
	}
}
