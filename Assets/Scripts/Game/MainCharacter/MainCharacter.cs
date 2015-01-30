using CX.Character;

namespace Game.Character
{
	public class MainCharacter : CharacterBase
	{
		public MainCharacter (ICharacterView view) : base (view)
		{
		}




		public class MainCharacterLife : ICharacterLifeCyle
		{
			IGameFlow gameFlow = new GameFlowController();

			public void Dead()
			{
				gameFlow.Stop();
			}
		}
	}
}

