using UnityEngine;
using CX.U3D.Character;

public class MainCharacter : CharacterView
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Blocker")
		{

		}
	}
}


