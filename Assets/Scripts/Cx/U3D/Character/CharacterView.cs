using UnityEngine;
using CX.Character;
using CX.Obj;

namespace CX.U3D.Character
{
	public class CharacterView : U3DGameObjectView, ICharacterView
	{
		public void Destroy()
		{
			ComponentTool.Destroy(gameObject);
		}

		public ICharacter Character {
			get 
			{
				return HostObject as ICharacter;
			}
			set 
			{
				HostObject = Character;
			}
		}
	}
}

