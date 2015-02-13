/// <summary>
/// Game flow. Controll game while playing level.
/// </summary>
using System;

public interface IGameFlow
{
	event EventHandler GameStart;

	event EventHandler GameRestart;

	event EventHandler GamePause;

	event EventHandler GameResume;

	event EventHandler GameStop;

	event EventHandler GameExit;

	/// <summary>
	/// Start Game.
	/// </summary>
	void Start();

	/// <summary>
	/// Restart Game.
	/// </summary>
	void Restart();

	/// <summary>
	/// Pause Game.
	/// </summary>
	void Pause();

	/// <summary>
	/// Pause Game.
	/// </summary>
	void Resume();

	/// <summary>
	/// Stop Game.
	/// </summary>
	void Stop();

	/// <summary>
	/// Exit Game
	/// </summary>
	void Exit();
}
