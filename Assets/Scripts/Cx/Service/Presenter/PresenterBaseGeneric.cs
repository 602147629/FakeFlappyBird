using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public abstract class PresenterBase<TView> : IPresenter<TView> where TView : class
	{
		protected TView view;

		public virtual TView View
		{
			get
			{
				return view;
			}
			set
			{
				view = value;
				InitializeView();
			}
		}

		IView IPresenter.View
		{
			get
			{
				return View as IView;
			}
			set
			{
				View = value as TView;
			}
		}

		/// <summary>
		/// Initializes the view when setup the view.
		/// Do some event binding and view init etc.
		/// </summary>
		protected virtual void InitializeView()
		{

		}
	}
}

