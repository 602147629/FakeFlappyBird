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
			const int life = 5;
			ValueChage<int> lifeChange = new ValueChage<int>(life);
			bool Invincible { get; set; }
			CountTimer invincibleTimer = new CountTimer(3, 1);

			public MainCharacterLife()
			{
				lifeChange.AddListener(GameFacade.ViewMgr.GetView<Game.View.InGameView>().lifeChangeText);
				lifeChange.Value = life;
				invincibleTimer.RunOnce = false;
				invincibleTimer.Elapsed += (nowCount) => Invincible = false; 
			}

			public void Dead()
			{
				if (Invincible) return;

				lifeChange.Value -= 1;
				invincibleTimer.Start();
				Invincible = true;

				if (lifeChange.Value <= 0)
				{
					Invincible = false;
					GameFacade.ViewFlow.Forward("GameOverView");
					GameFacade.GameFlow.Stop();
				}

			}
		}
	}
}

