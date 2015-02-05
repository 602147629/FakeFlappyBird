using System;
namespace CX.Obj
{
	public abstract class CxObject<T> : ICxObject
	{
		private T bornVO;

		protected CxObject(T bornVO)
		{
			this.bornVO = bornVO;
		}

		public abstract void Create();

		public abstract void Destroy();
	}
}

