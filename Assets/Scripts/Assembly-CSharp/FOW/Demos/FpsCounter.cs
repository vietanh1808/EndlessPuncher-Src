using UnityEngine;
using UnityEngine.UI;

namespace FOW.Demos
{
	public class FpsCounter : MonoBehaviour
	{
		public Text FpsText;

		public Text MsText;

		public float UpdateInterval;

		private int frames;

		private float lastUpdateTime;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
