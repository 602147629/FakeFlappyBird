namespace CX.Obj
{
	public abstract class PooledObject<T> : IPooledObject<T>
	{
		public abstract T Make();

		public virtual void Active(T obj)
		{
		}

		public virtual void InAactive(T obj)
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