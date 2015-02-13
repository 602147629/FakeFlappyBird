using UnityEngine;
using CX.U3D.Character;
using System.Collections;

namespace Game.Character
{
	public class BlockerView : CharacterView 
	{		
		// Use this for initialization
		void OnEnable () 
		{
			//StartCoroutine(BecomeInvisible());
		}	


		IEnumerator BecomeInvisible()
		{
			yield return new WaitForSeconds(5);
			GameFacade.ObjectPool.PutBack(Character);
		}
	}
}

