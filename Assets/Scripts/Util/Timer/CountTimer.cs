
public class CountTimer : Timer
{
	public CountTimer (int totalCount) : this (1, totalCount)
	{
	}

	public CountTimer (float interval, int totalCount) : base (interval)
	{
		this.TotalCount = totalCount;
	}

	public int TotalCount
	{
		get; set;
	}

	public event TimeElapsedEvent TimerInit;
	public event TimeElapsedEvent TimerFinished;

	public override void Start ()
	{
		nowCount = 0;
		if (TimerInit != null)
			TimerInit(nowCount);
		base.Start ();
	}

	protected override void Count ()
	{
		base.Count ();
		if (TimerFinished != null && nowCount == TotalCount)
		{
			TimerFinished(nowCount);
		}
	}

	public override bool IsEnabled
	{
		get 
		{
			return base.IsEnabled && nowCount < TotalCount;
		}
	}
}


