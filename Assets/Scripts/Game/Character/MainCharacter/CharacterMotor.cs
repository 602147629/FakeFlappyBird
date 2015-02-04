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
		
		void Start () {
			if (character == null) character = GetComponent<CharacterController>();	
		}
		
		void FixedUpdate()
		{
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
