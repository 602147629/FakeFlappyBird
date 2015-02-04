using UnityEngine;
using CX.U3D.Character;

namespace Game.Character
{
	public class MainCharacterView : CharacterView
	{
		void OnTriggerEnter(Collider other) 
		{
			if (other.tag == "Blocker")
			{
				Character.Life.Dead();
			}
		}
	}
}



