namespace CX.Obj
{
	public interface IGameObjectView
	{
		IGameObject HostObject { get; set; }
		void Destroy();
	}
}

