/// <summary>
/// Game flow. Controll game while playing level.
/// </summary>
public interface IGameFlow
{
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
}
