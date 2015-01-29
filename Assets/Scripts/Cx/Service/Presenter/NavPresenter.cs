using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public class NavPresenter : PresenterBase, IViewNavable
	{		
		IViewFlow viewFlow;

		public IViewFlow ViewFlow 
		{
			get 
			{
				return viewFlow;
			}
			set 
			{
				viewFlow = value;
			}
		}

		public virtual void NavTo(string viewName)
		{
			viewFlow.Forward(viewName);
		}

		public virtual void NavBack()
		{
			viewFlow.Back();
		}
	}
}