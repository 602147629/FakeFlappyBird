using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public interface IViewNavable
	{
		IViewFlow ViewFlow 
		{
			get; set;
		}

		void NavTo(string viewName);
		
		
		void NavBack();
		
	}
}

