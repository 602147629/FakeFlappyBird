using System;
using NUnit.Framework;
using CX;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace SimpleTest
{
	/// <summary>
	/// This Test is just use for some simple tests, not about game.
	/// </summary>
	[TestFixture]
	public class SimpleTest
	{
		public class A
		{
			public int num1;
			public int num2;

			public A (int num1, int num2)
			{
				this.num1 = num1;
				this.num2 = num2;
			}		
		}

		[SetUp]
		public void SetUp()
		{

		}

		void Swap<T>(T first, T two)
		{
			T temp = first;
			first = two;
			two = temp;
		}

		void Swap<T>(ref T first, ref T two)
		{
			T temp = first;
			first = two;
			two = temp;
		}

		/// <summary>
		/// O'Reilly's Java in a Nutshell by David Flanagan puts it best: "Java manipulates objects 'by reference,' but it passes object references to methods 'by value.'" As a result, you cannot write a standard swap method to swap objects.
		/// I think it is same in C#, but it can do a swap method by using ref.
		/// </summary>
		[Test]
		public void SwapTest()
		{
			A a1 = new A(1, 2);
			A a2 = new A(3, 4);

			Swap(ref a1, ref a2);
			//Swap(a1, a2);

			Assert.AreEqual(a1.num1, 3);
			Assert.AreEqual(a1.num2, 4);
			Assert.AreEqual(a2.num1, 1);
			Assert.AreEqual(a2.num2, 2);
		}

		[Test]
		public void CreateObj()
		{
			A a = CreateHelper.Create<A>( 1, 2);

			Assert.AreEqual(a.num1, 1);
			Assert.AreEqual(a.num2, 2);

		}

		public delegate void Del();
		public Del del;

		static void StDel()
		{
			Debug.Log("C");
		}

		void InsDel()
		{
			Debug.Log("D");
		}

		[Test]
		public void DelegateTest()
		{
			//del();
			Del del = InsDel;
			del += delegate() {
				Debug.Log("A");
			};
			del += delegate() {
				Debug.Log("B");
			};

			del();
			del = InsDel;

			del();
			del += StDel;
			del();


		}

		[Test]
		public void JustTest()
		{
			GameScoreList gs = new GameScoreList();

			for (int i = 0; i < 20; i ++)
			{
				gs.AddScore(UnityEngine.Random.Range(0, 9));
			}

			foreach (var g in gs.ScoreList)
			{
				Debug.Log(g);
			}

			Debug.Log("-----");

			gs.AddScore(23);
			gs.AddScore(11);
			foreach (var g in gs.ScoreList)
			{
				Debug.Log(g);
			}


		}

	}

	public class DelTest
	{
		public void D()
		{
			SimpleTest st = new SimpleTest();
			st.del = null;
		}
	}
}


