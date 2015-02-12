namespace CX.Obj
{
	public interface IObjectPool<T>
	{
		T GetOne();

		void PutBack(T obj);
	}
}