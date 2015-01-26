using UnityEngine;
using System;
using CX.Character;

namespace CX.U3D.Character
{
	public class U3DCharacter : MonoBehaviour, ICharacter
	{

		public ICharacterLifeCyle Life {
			get;set;
		}

		public void Destroy ()
		{
#if UNITY_EDITOR
			DestroyImmediate(gameObject);
#else
			Destroy(gameObject);
#endif
		}
	}
}

