using System;

namespace CX.Obj
{
	public interface IPooledObject
	{
		Type CreateVOType { get; set; }
	}		
}

