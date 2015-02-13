using System;
namespace CX.Obj
{
	public abstract class CxObject<T> : ICxObject
	{
		protected T bornVO;

		protected CxObject(T bornVO)
		{
			this.bornVO = bornVO;
		}

		public abstract void Create();

		public abstract void Destroy();
	}
}

