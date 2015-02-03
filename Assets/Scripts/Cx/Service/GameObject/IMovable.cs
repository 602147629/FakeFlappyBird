namespace CX.Obj
{
	public interface IMovable
	{
		void StartMove();

		void StopMove();

		bool IsMoving { get; }
	}
}

