
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

	public override void Start ()
	{
		nowCount = 0;
		base.Start ();
	}

	public override bool IsEnabled
	{
		get 
		{
			return base.IsEnabled && nowCount < TotalCount;
		}
	}
}


