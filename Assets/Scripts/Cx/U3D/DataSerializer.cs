using CX.Serialize;
using UnityEngine;

namespace CX.U3D.Serialize
{
	public class DataSerializer : ISerializer
	{
		ISerializer serializer;

		public DataSerializer ()
		{
			serializer = new BinarySerializer(PersistencePath);
		}

		string PersistencePath
		{
			get { return Application.dataPath + "/../Save/"; }
		}

		#region ISerializer implementation
		public void Serialize (object toSerialize)
		{
			serializer.Serialize(toSerialize);
		}
		public T Deserialize<T> ()
		{
			return serializer.Deserialize<T>();
		}
		#endregion
	}
}

