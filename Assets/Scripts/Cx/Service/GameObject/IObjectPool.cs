using System;

namespace CX.Obj
{
	/// <summary>
	/// Object Pool.Cache objects for perfomance optimize.
	/// </summary>
	public interface IObjectPool
	{
		/// <summary>
		/// Regs the creater <see cref="ObjectCreater"/>.
		/// Detailed job of create an object is delegate to creater.
		/// </summary>
		/// <param name="creater">Creater.</param>
		void RegCreater(PooledObjectCreater creater);

		/// <summary>
		/// Gets one specified type object from pool.
		/// </summary>
		/// <returns>The one.</returns>
		/// <param name="type">Object Type.</param>
		IGameObject GetOne(Type type);

		/// <summary>
		/// Puts one back to pool.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		void PutBack(IGameObject gameObject);
	}
}

