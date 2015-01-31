using System;

namespace Game.Character
{
	public class CharacterHealth
	{
		private float health;

		public float Health 
		{
			get 
			{
				return health;
			}
			set 
			{
				health = value;
			}
		}

		public void IncreaseHealth(int increase)
		{
			health += increase;
		}

		public void DecreaseHealth(int decrease)
		{
			health -= decrease;
		}
	}
}

