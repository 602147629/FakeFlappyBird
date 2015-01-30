using CX.MVP.Presenter;

namespace CX.MVP.View
{
	public abstract class ViewManagerBase 
	{
		public static readonly IView EmptyView = new NullView();

		public class NullView : IView
		{
			public void Show(bool isShow)
			{
			}
			
			public override string ToString()
			{
				return string.Format("[NullView]");
			}
			
			public string ViewName
			{
				get; set;
			}

			public IPresenter Presenter
			{
				get;set;
			}
		}
	}
}

