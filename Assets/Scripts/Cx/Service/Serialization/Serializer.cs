namespace CX.Serialize
{
	public abstract class Serializer : ISerializer
	{
		protected string serializePath;

		protected Serializer (string serializePath)
		{
			this.serializePath = serializePath;
		}

		#region ISerializer implementation

		public abstract void Serialize (object toSerialize);

		public abstract T Deserialize<T> ();

		#endregion
	}
}

