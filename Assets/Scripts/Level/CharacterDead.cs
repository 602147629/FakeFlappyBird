using UnityEngine;
namespace Character
{
	public class CharacterDead : MonoBehaviour
	{
		void OnTriggerEnter(Collider other) 
		{
			if (other.tag == "Blocker")
			{
				Debug.Log("DEAD!!!");
			}
		}
	}
}

