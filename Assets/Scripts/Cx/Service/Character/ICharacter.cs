using CX.Obj;

namespace CX.Character
{
	/// <summary>
	/// Character Interface.
	/// </summary>
	public interface ICharacter : IGameObject
	{
		/// <summary>
		/// ICharacterLifeCyle Property.
		/// </summary>
		/// <value>The life.</value>
		ICharacterLifeCyle Life { get; set; }

		new ICharacterView View { get; set; }
	}
}

