using System.Collections.Generic;
using UnityEngine;

namespace FOW
{
	public class PartialHiderRegisterer : MonoBehaviour
	{
		public Material[] MaterialsToInitialize;

		private Dictionary<Material, PartialHider> InitializedMaterials;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void RegisterMaterials()
		{
		}

		public void DeRegisterMaterials()
		{
		}
	}
}
