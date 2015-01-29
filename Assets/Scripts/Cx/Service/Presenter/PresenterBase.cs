using CX.MVP.View;

namespace CX.MVP.Presenter
{
	public abstract class PresenterBase : IPresenter
	{
		protected IView view;

		public virtual IView View
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

		/// <summary>
		/// Initializes the view when set the view.
		/// Do some event binding and view init etc.
		/// </summary>
		protected virtual void InitializeView()
		{
			
		}
	}
}

