using CX.Obj;

namespace CX.U3D.Obj
{
	public class CxGameObjectPooled : IPooledObject<CxGameObject>
	{
		BornVO bornVO;

		public CxGameObjectPooled(BornVO bornVO)
		{
			this.bornVO = bornVO;
		}

		public CxGameObject Make()
		{
			return CreateHelper.Create<CxGameObject>(bornVO.ObjectType, bornVO);
		}

		public void Active(CxGameObject obj)
		{
			obj.Create();
		}

		public void InAactive(CxGameObject obj)
		{
			obj.Destroy();
		}

		public void Destroy(CxGameObject obj)
		{
			//throw new System.NotImplementedException();
		}

		public bool Validate(CxGameObject obj)
		{
			return true;
		}
	}
}
