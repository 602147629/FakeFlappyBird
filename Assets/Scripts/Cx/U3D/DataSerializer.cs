using CX.Serialize;
using UnityEngine;
using System;

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
			SetEnviroment();
			serializer.Serialize(toSerialize);
		}
		public T Deserialize<T> ()
		{
			SetEnviroment();
			return serializer.Deserialize<T>();
		}
		#endregion

		void SetEnviroment()
		{
			Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");
		}
	}
}

