using CX.Obj;

namespace CX.Character
{
	public interface ICharacterView : IGameObjectView
	{
		ICharacter Character { get; set; }
	}
}

