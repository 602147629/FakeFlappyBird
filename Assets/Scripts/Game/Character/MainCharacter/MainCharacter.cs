using CX.U3D.Character;
using CX.Character;
using CX.U3D;
using Game;

namespace Game.Character
{
	public class MainCharacter : CharacterBase
	{
		public MainCharacter (GameObjectBornVO bornVO) : base(bornVO)
		{
			Life = new MainCharacterLife();
		}

		public class MainCharacterLife : ICharacterLifeCyle
		{
			public void Dead()
			{
				GameFacade.ViewFlow.Forward("GameOverView");
				GameFacade.GameFlow.Stop();
			}
		}
	}
}

