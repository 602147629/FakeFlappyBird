namespace CX.Character
{
	/// <summary>
	/// Character Interface.
	/// </summary>
	public interface ICharacter
	{
		/// <summary>
		/// ICharacterLifeCyle Property.
		/// </summary>
		/// <value>The life.</value>
		ICharacterLifeCyle Life { get; set; }

		void Destroy();
	}
}

