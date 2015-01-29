using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public class NavPresenter
	{		
		IViewFlow viewFlow;

		public void NavTo(string viewName)
		{
			viewFlow.Forward(viewName);
		}

		public void NavBack()
		{
			viewFlow.Back();
		}
	}
}