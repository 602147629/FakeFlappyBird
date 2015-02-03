using CX.Character;
using Game;

namespace Game.Character
{
	public class MainCharacter : CharacterBase
	{
		public MainCharacter ()
		{
			Life = new MainCharacterLife();
		}




		public class MainCharacterLife : ICharacterLifeCyle
		{
			public void Dead()
			{
				GameFacade.ViewFlow.Forward("GameOverView");

			}
		}
	}
}

