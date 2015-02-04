namespace CX.Obj
{
	/// <summary>
	/// Object creater.
	/// Creates an object<see cref="CX.Obj.IGameObject"/> by its <see cref="CX.Obj.BornVO"/>
	/// </summary>
	public abstract class ObjectCreater
	{
		/// <summary>
		/// Create one object <see cref="CX.Obj.IGameObject"/>.
		/// </summary>
		/// <param name="bornVO"><see cref="CX.Obj.BornVO"/></param>
		public abstract IGameObject Create(BornVO bornVO);		
	}
}

