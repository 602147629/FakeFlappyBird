namespace CX.Obj
{
	public interface IPooledObject<T>
	{
		T Make();

		void Activate(T obj);

		void InAactivate(T obj);

		void Destroy(T obj);

		bool Validate(T obj);
	}
}