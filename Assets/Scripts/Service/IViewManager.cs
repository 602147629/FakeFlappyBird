using System;

/// <summary>
/// ViewManager, Create and Get View by view Name.
/// </summary>
public interface IViewManager
{
	/// <summary>
	/// Gets the view.
	/// </summary>
	/// <returns>The view.</returns>
	/// <param name="viewName">View name.</param>
	IView GetView(string viewName);

	/// <summary>
	/// Gets the view. Generic type.
	/// </summary>
	/// <returns>The view.</returns>
	/// <param name="viewName">View name.</param>
	/// <typeparam name="TView">The 1st type parameter.</typeparam>
	TView GetView<TView>(string viewName) where TView : class, IView;

	/// <summary>
	/// Creates the view.
	/// </summary>
	/// <returns>The view.</returns>
	/// <param name="viewName">View name.</param>
	IView CreateView(string viewName);

	/// <summary>
	/// Creates the view. Generic type.
	/// </summary>
	/// <returns>The view.</returns>
	/// <param name="viewName">View name.</param>
	/// <typeparam name="TView">The 1st type parameter.</typeparam>
	TView CreateView<TView>(string viewName) where TView : class, IView;
}


