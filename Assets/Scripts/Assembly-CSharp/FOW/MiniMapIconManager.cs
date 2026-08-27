using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FOW
{
	[DefaultExecutionOrder(-50)]
	public class MiniMapIconManager : MonoBehaviour
	{
		public static MiniMapIconManager instance;

		[Header("References")]
		public Image MapImageComponent;

		public Image IconPrefab;

		[Header("Optimization")]
		[Tooltip("The maximum number of icons you expect to register. This will auto expand if needed.")]
		public int InitialMaxCapacity;

		private Dictionary<Transform, Image> activeIcons;

		private Stack<Image> pooledIcons;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private Image CreateNewImage()
		{
			return null;
		}

		private Image PullImageFromPool()
		{
			return null;
		}

		public void TrackNewObject(Transform tracker, float scale, Color color, Sprite sprite)
		{
		}

		public void StopTrackingObject(Transform tracker)
		{
		}
	}
}
