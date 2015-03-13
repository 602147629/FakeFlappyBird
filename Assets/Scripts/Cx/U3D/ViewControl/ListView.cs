using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

namespace CX.U3D.View 
{
	public class ListView : MonoBehaviour
	{
		public GameObject contentRoot;
		public GameObject itemPrefab;

		public event Action<GameObject, int> OnItemAdd;
		public event Action<GameObject> OnItemEnable;
		public event Action<GameObject> OnItemDisable;
		VerticalLayoutGroup l;

		private int itemIndex;
		private List<GameObject> contentList = new List<GameObject>();

		void Start()
		{

		}

		void OnEnable()
		{
			foreach (var item in contentList)
			{
				if (item != null && OnItemEnable != null)
					OnItemEnable(item);
			}
		}

		void OnDisable()
		{
			foreach (var item in contentList)
			{
				if (item != null && OnItemDisable != null)
					OnItemDisable(item);
			}
		}

		public void AddItemList(int itemCount)
		{
			var newItem = Instantiate(itemPrefab) as GameObject;
			contentList.Add(newItem);

			itemIndex ++;
			if (OnItemAdd != null)
				OnItemAdd(newItem, itemIndex);

			if (itemIndex == itemCount)
				StartCoroutine(AddFinish());
		}

		IEnumerator AddFinish()
		{
			yield return new WaitForEndOfFrame();
		}

	}

}
