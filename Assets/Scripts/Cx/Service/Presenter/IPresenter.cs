using CX.MVP.View;

namespace CX.MVP.Presenter
{
	/// <summary>
	/// Presenter Interface. All presenter class must implement this interface.
	/// Presenter is uses to:
	/// 1. Accepet event from View <see cref="IView"/>,  and handle the event;
	/// 2. Update domain model;
	/// 3. Listen to domain model and manipulate the view's state.
	/// </summary>
	public interface IPresenter
	{
		/// <summary>
		/// View Property
		/// </summary>
		/// <value>The view.</value>
		IView View { get; set; }
	}
}

