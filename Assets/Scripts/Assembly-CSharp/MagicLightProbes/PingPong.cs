using UnityEngine;

namespace MagicLightProbes
{
	public class PingPong : MonoBehaviour
	{
		public enum Direction
		{
			TopDown = 0,
			LeftRight = 1,
			ForwarBackward = 2
		}

		public Direction direction;

		public float distance;

		public float speed;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
