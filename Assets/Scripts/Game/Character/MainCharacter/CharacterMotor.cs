using UnityEngine;

namespace Game.Character
{
	public class CharacterMotor : MonoBehaviour
	{		
		public CharacterController character;
		public float forwardSpeed = 5;
		public float downSpeed = 5;
		public float upSpeed = 5;
		public float upTime = 0.5f;
		
		float verticalSpeed = 0;
		float upStarTime;
		bool isUp;
		bool isStop;
		
		void Start () {
			if (character == null) character = GetComponent<CharacterController>();

			GameFacade.GameFlow.GameResume += (sender, e) => GameStart();
			GameFacade.GameFlow.GamePause += (sender, e) => GameStop();
			GameFacade.GameFlow.GameStop += (sender, e) => GameStop();
			GameFacade.GameFlow.GameRestart += (sender, e) => GameStart();
		}

		void GameStart ()
		{
			isStop = false;
		}

		void GameStop ()
		{
			isStop = true;
		}
		
		void FixedUpdate()
		{
			if (isStop) return;

			if (Input.GetKeyDown(KeyCode.W))
			{
				upStarTime = Time.time;
				isUp = true;
			}
			if (isUp && Time.time - upStarTime <= upTime)
			{
				verticalSpeed = upSpeed;
			}
			else
			{
				verticalSpeed = 0;
				isUp = false;
			}
			character.Move(new Vector3(forwardSpeed,  verticalSpeed - downSpeed, 0) * Time.fixedDeltaTime);
		}
	}
}
