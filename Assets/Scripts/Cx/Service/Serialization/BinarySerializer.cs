using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CX.Serialize
{
	public class BinarySerializer : Serializer 
	{
		public BinarySerializer(string serializePath) : base(serializePath)
		{
		}

		#region Serializer implementation

		public override void Serialize (object toSerialize)
		{
			string path = serializePath + toSerialize.GetType().Name;
			Stream stream = new FileStream(path, FileMode.OpenOrCreate);
			BinaryFormatter b = new BinaryFormatter();
			b.Serialize(stream, toSerialize);
			stream.Close();	
		}

		public override T Deserialize<T> ()
		{
			string path = serializePath + typeof(T).Name;
				Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			BinaryFormatter b = new BinaryFormatter();
			object obj = b.Deserialize(stream);
			if (obj is T)
				return (T)obj;
			return default(T);
		}

		#endregion
	}
}

