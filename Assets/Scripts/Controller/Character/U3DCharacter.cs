using UnityEngine;
using System;
using CX.Character;

namespace CX.U3D.Character
{
	public class U3DCharacter : ICharacter
	{
		public U3DCharacter(IGameObjectView view)
		{
			this.View = view;
		}

		public ICharacterLifeCyle Life {
			get;set;
		}

		public IGameObjectView View
		{
			get;set;
		}
	}
}

