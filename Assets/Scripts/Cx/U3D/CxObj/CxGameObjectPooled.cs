using CX.Obj;

namespace CX.U3D.Obj
{
	public class CxGameObjectPooled<T> : IPooledObject<T> where T : CxGameObject
	{
		BornVO bornVO;

		public CxGameObjectPooled(BornVO bornVO)
		{
			this.bornVO = bornVO;
		}

		public T Make()
		{
			return CreateHelper.Create<T>(bornVO.ObjectType, bornVO);
		}

		public void Activate(T obj)
		{
			obj.Create();
		}

		public void InAactivate(T obj)
		{
			obj.Destroy();
		}

		public void Destroy(T obj)
		{
		}

		public bool Validate(T obj)
		{
			return true;
		}
	}
}
