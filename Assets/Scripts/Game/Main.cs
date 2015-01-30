using UnityEngine;
using Game;

/// <summary>
/// Game Initialize
/// </summary>
public class Main : MonoBehaviour
{
	void Awake()
	{
		GameFacade facade = new GameFacade();
		facade.StartGame();

	}
}