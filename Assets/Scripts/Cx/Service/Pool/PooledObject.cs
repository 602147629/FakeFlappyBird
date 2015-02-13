namespace CX.Obj
{
	public abstract class PooledObject<T> : IPooledObject<T>
	{
		public abstract T Make();

		public virtual void Activate(T obj)
		{
		}

		public virtual void InAactivate(T obj)
		{
		}

		public virtual void Destroy(T obj)
		{
		}

		public bool Validate(T obj)
		{
			return true;
		}
	}
}