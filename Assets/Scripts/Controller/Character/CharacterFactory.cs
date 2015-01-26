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
			return ins.GetComponent<U3DCharacter>();
		}
	}
}

