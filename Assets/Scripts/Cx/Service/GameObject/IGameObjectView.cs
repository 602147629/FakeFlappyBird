namespace CX.Obj
{
	/// <summary>
	/// Every <see cref="CX.Obj.IGameObject"/> has a <see cref="CX.Obj.IGameObjectView"/>
	/// </summary>
	public interface IGameObjectView
	{
		/// <summary>
		/// Gets or sets the host object <see cref="CX.Obj.IGameObject"/>.
		/// </summary>
		/// <value>The host object.</value>
		IGameObject HostObject { get; set; }

		/// <summary>
		/// Destroy this instance.
		/// </summary>
		void Destroy();

		/// <summary>
		/// Actives or disactives the view.
		/// </summary>
		/// <param name="isActive">If set to <c>true</c> is active.</param>
		void Active(bool isActive);

		/// <summary>
		/// Gets a value indicating whether this instance is active.
		/// </summary>
		/// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
		bool IsActive { get; }
	}
}

