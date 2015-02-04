namespace CX.Obj
{
	/// <summary>
	/// All gameobjects in game must implement this interface.
	/// </summary>
	public interface IGameObject
	{
		/// <summary>
		/// Gets or sets the view <see cref="CX.Obj.IGameObjectView"/>.
		/// </summary>
		/// <value>The view.</value>
		IGameObjectView View { get; set; }
	}
}

