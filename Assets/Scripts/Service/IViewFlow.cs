/// <summary>
/// Navigate between views.
/// </summary>
public interface IViewFlow
{
	/// <summary>
	/// Forward the specified view.
	/// </summary>
	/// <param name="viewName">View name.</param>
	void Forward(string viewName);

	/// <summary>
	/// Go back to last view.
	/// </summary>
	IView Back();

	/// <summary>
	/// Go back to the specified view.
	/// </summary>
	/// <param name="viewName">View name.</param>
	IView Back(string viewName);

	/// <summary>
	/// Gets the current view.
	/// </summary>
	/// <value>The current view.</value>
	IView CurrentView { get; }
}


