namespace CX.MVP.View
{
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
		TView GetView<TView>() where TView : class, IView;
		
		/// <summary>
		/// Creates the view.
		/// </summary>
		/// <returns>The view.</returns>
		/// <param name="viewResource">View Resource.</param>
		IView CreateView(object viewResource);
		
		/// <summary>
		/// Creates the view. Generic type.
		/// </summary>
		/// <returns>The view.</returns>
		/// <param name="viewResource">View Resource.</param>
		/// <typeparam name="TView">The 1st type parameter.</typeparam>
		TView CreateView<TView>(object viewResource) where TView : class, IView;

		/// <summary>
		/// Gets the view flow <see cref="IViewFlow"/>.
		/// </summary>
		/// <value>The view flow.</value>
		IViewFlow ViewFlow { get; }
	}
}



