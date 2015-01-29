using CX.Character;
using UnityEngine;

namespace CX.U3D.Character
{
	public class CharacterFactory
	{
		public CharacterFactory ()
		{
		}

		public ICharacter Create(string name)
		{
			Object res = Resources.Load(name);
			GameObject ins = GameObject.Instantiate(res) as GameObject;

			CharacterView cv = ins.AddComponent<CharacterView>();
			return new U3DCharacter(cv);

		}
	}
}

