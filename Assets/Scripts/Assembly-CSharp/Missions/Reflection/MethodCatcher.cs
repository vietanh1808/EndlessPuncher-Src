using System;
using System.Reflection;
using UnityEngine;

namespace Missions.Reflection
{
	[Serializable]
	public class MethodCatcher
	{
		[Serializable]
		public struct SerializableParameterSerializer
		{
			[SerializeReference]
			public SerializableParameter parameter;

			public object Value => null;
		}

		[Serializable]
		public class SerializableParameter
		{
			public enum ParameterTypes
			{
				Int32 = 0,
				Float = 1,
				String = 2,
				Bool = 3,
				Vector2 = 4,
				Vector3 = 5,
				Enum = 6,
				Quaternion = 7,
				Color = 8,
				Rect = 9,
				Bounds = 10,
				LayerMask = 11,
				AnimationCurve = 12,
				Gradient = 13,
				Texture2D = 14,
				Texture3D = 15,
				Cubemap = 16,
				Sprite = 17,
				GameObject = 18,
				Transform = 19,
				Material = 20,
				Mesh = 21,
				AnimationClip = 22,
				AudioClip = 23,
				Shader = 24,
				RenderTexture = 25,
				Collider = 26,
				Terrain = 27,
				TerrainData = 28,
				ScriptableObject = 29,
				MonoBehaviour = 30,
				CustomSerializable = 31
			}

			[SerializeField]
			private int intValue;

			[SerializeField]
			private float floatValue;

			[SerializeField]
			private string stringValue;

			[SerializeField]
			private bool boolValue;

			[SerializeField]
			private Vector2 vector2Value;

			[SerializeField]
			private Vector3 vector3Value;

			[SerializeField]
			private Quaternion quaternionValue;

			[SerializeField]
			private Color colorValue;

			[SerializeField]
			private Rect rectValue;

			[SerializeField]
			private Bounds boundsValue;

			[SerializeField]
			private AnimationCurve animationCurveValue;

			[SerializeField]
			private Gradient gradientValue;

			[SerializeField]
			private UnityEngine.Object objectValue;

			public Type resultType;

			public ParameterTypes type;

			public object value
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		public MonoBehaviour target;

		public string methodName;

		public bool isResultBool;

		public SerializableParameterSerializer[] parameters;

		private object[] _parameters;

		private Delegate _method;

		private Delegate CreateDelegateForMethod(MonoBehaviour target, string methodName)
		{
			return null;
		}

		private Type CreateDelegateType(MethodInfo method)
		{
			return null;
		}

		public void Catch()
		{
		}

		public object Invoke()
		{
			return null;
		}
	}
}
