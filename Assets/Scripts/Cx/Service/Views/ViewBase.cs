using CX.MVP.Presenter;

namespace CX.MVP.View
{
	public abstract class ViewBase : IView
	{
		string viewName;
		IPresenter presenter;

		public virtual void Show(bool isShow)
		{

		}

		public string ViewName
		{
			get
			{
				return viewName;
			}
			set
			{
				viewName = value;
			}
		}

		public IPresenter Presenter
		{
			get
			{
				return presenter;
			}
			set
			{
				presenter = value;
			}
		}
	}
}

