using UnityEngine;
using CX.U3D.Character;
using CX.Character;
using CX.U3D;

namespace Game.Character
{
	public class MainCharacterView : U3DGameObjectView
	{
		void OnTriggerEnter(Collider other) 
		{
			if (other.tag == "Blocker")
			{
				(HostObject as ICharacter).Life.Dead();
			}
		}
	}
}
