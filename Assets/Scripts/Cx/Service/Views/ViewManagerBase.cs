namespace CX.MVP.View
{
	public abstract class ViewManagerBase : IViewManager
	{
		public static readonly IView EmptyView = new NullView();

		public virtual IView GetView(string viewName)
		{
			throw new System.NotImplementedException();
		}

		public virtual TView GetView<TView>(string viewName) where TView : class, IView
		{
			throw new System.NotImplementedException();
		}

		public virtual IView CreateView(object viewResource)
		{
			throw new System.NotImplementedException();
		}

		public virtual TView CreateView<TView>(object viewResource) where TView : class, IView
		{
			throw new System.NotImplementedException();
		}

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
		}
	}
}

