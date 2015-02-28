using System;
namespace CX.Obj
{
	public abstract class CxObject<T> : IActivable
	{
		protected T bornVO;

		protected CxObject(T bornVO)
		{
			this.bornVO = bornVO;
		}

		public abstract void Activate();

		public abstract void InActivate();
	}
}

