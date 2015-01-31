using CX.Character;
using Game.Character;
using UnityEngine;

namespace CX.U3D.Character
{
	public class CharacterFactory
	{
		public CharacterFactory ()
		{
		}

		public static ICharacter Create(string name)
		{
			Object res = Resources.Load(name);
			GameObject ins = GameObject.Instantiate(res) as GameObject;

			CharacterView view = ins.GetComponent<CharacterView>();
			ICharacter c =  new MainCharacter();
			c.View = view;
			c.Life = new MainCharacter.MainCharacterLife();

			return c;
		}
	}
}

