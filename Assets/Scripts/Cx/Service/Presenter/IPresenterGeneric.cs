using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public interface IPresenter<TView> : IPresenter where TView : class
	{
		new TView View { get; set; }
	}
}



