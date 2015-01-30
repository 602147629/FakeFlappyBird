using UnityEngine;
using CX.Character;
using CX.Obj;

namespace CX.U3D.Character
{
	public class CharacterView : MonoBehaviour, ICharacterView
	{
		public void Destroy()
		{
			ComponentTool.Destroy(gameObject);
		}

		public void Show(bool isShow)
		{
			gameObject.SetActive(isShow);
		}

		public string ViewName
		{
			get;set;
		}

		public ICharacter Character
		{
			get;set;
		}

		IGameObject IGameObjectView.HostObject
		{
			get;set;
		}
	}
}

