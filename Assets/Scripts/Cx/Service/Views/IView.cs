using CX.MVP.Presenter;

namespace CX.MVP.View
{
	public interface IView
	{
		void Show(bool isShow);
		string ViewName { get; set; }
		IPresenter Presenter { get; set; }
	}
}

