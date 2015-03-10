namespace CX.Serialize
{
	public interface ISerializer
	{
		void Serialize(object toSerialize);
		T Deserialize<T>();
	}
}


