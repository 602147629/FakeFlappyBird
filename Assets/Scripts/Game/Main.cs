using UnityEngine;

/// <summary>
/// Game Initialize
/// </summary>
public class Main : MonoBehaviour
{
	void Awake()
	{
		Debug.Log(typeof(Game.View.WelcomeViewPresenter));
		Debug.Log(System.Type.GetType("Game.View.WelcomeViewPresenter"));
	}
}