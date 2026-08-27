Shader "Shader Graphs/ShieldDamageS" {
	Properties {
		_Alpha_A ("Alpha_A", Float) = 1
		_Widht_Height ("Widht-Height", Vector) = (0.5,0.5,0,0)
		_offset ("offset", Vector) = (0,0,0,0)
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		[NoScaleOffset] _AlphaMap ("AlphaMap", 2D) = "white" {}
		[HDR] _Color ("Color", Vector) = (1,1,1,0)
		_DistortionScale ("DistortionScale", Float) = 25
		_DistortionPower ("DistortionPower", Range(0, 1)) = 0
		[Toggle(_USEALPHAMAP)] _USEALPHAMAP ("UseAlphaMap", Float) = 0
		[Toggle(_USEDISTORTION)] _USEDISTORTION ("UseDistortionMap", Float) = 0
		_DistortionMap ("DistortionMap", 2D) = "white" {}
		_DistortionSpeed ("DistortionSpeed", Vector) = (0,0,0,0)
		[ToggleUI] _UseCustomData ("UseCustomData", Float) = 0
		[ToggleUI] _UseVertexColor ("UseVertexColor", Float) = 0
		_FrenselPower ("FrenselPower", Float) = 1
		_FrenselSmoothStep ("FrenselSmoothStep", Vector) = (0,0,0,0)
		_FrenselOpacity ("FrenselOpacity", Float) = 0
		[Toggle(_USE_DISSOLVE_UV2_4)] _USE_DISSOLVE_UV2_4 ("Use-Dissolve-UV2-4", Float) = 0
		[HideInInspector] _CastShadows ("_CastShadows", Float) = 1
		[HideInInspector] _Surface ("_Surface", Float) = 0
		[HideInInspector] _Blend ("_Blend", Float) = 0
		[HideInInspector] _AlphaClip ("_AlphaClip", Float) = 0
		[HideInInspector] _SrcBlend ("_SrcBlend", Float) = 1
		[HideInInspector] _DstBlend ("_DstBlend", Float) = 0
		[HideInInspector] _SrcBlendAlpha ("_SrcBlendAlpha", Float) = 1
		[HideInInspector] _DstBlendAlpha ("_DstBlendAlpha", Float) = 0
		[ToggleUI] [HideInInspector] _ZWrite ("_ZWrite", Float) = 1
		[HideInInspector] _ZWriteControl ("_ZWriteControl", Float) = 0
		[HideInInspector] _ZTest ("_ZTest", Float) = 4
		[HideInInspector] _Cull ("_Cull", Float) = 2
		[HideInInspector] _AlphaToMask ("_AlphaToMask", Float) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] _XRMotionVectorsPass ("_XRMotionVectorsPass", Float) = 1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}