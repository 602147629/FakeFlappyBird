using UnityEngine;
using CX.Character;

namespace CX.U3D.Character
{
	public class CharacterView : MonoBehaviour, IGameObjectView
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
	}
}

