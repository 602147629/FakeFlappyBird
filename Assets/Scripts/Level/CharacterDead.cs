using UnityEngine;
using CX.U3D.Character;

public class CharacterDead : MonoBehaviour
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Blocker")
		{
			GetComponent<U3DCharacter>().Life.Dead();
		}
	}
}


