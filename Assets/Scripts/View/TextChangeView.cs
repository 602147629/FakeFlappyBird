using System;
using CX.U3D.MVP.View;
using UnityEngine.UI;
using UnityEngine;

namespace Game.View
{
	public class TextChangeView : MonoBehaviour, IValueListener<int>
	{
		public Text text;

		void Awake()
		{
			if (text == null)
				text = GetComponent<Text>();
		}

		public void OnChange(int newValue)
		{
			if (text != null)
				text.text = newValue.ToString();
		}
	}
}

