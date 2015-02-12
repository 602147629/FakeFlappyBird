namespace CX.Obj
{
	public interface IPooledObject<T>
	{
		T Make();

		void Active(T obj);

		void InAactive(T obj);

		void Destroy(T obj);

		bool Validate(T obj);
	}
}