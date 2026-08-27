Shader "Shader Graphs/Dissolve-Basic-Fubu" {
	Properties {
		_Alpha_A ("Alpha_A", Float) = 1
		[HDR] _Color ("Color", Vector) = (1,1,1,0)
		[NoScaleOffset] _MainAlpha ("MainAlpha", 2D) = "white" {}
		_AlphaPower ("AlphaPower", Float) = 3
		_Dissolve ("Dissolve", Range(0, 1)) = 0
		[Toggle(_CUSTOMDATAUSE)] _CUSTOMDATAUSE ("CustomDataUse?", Float) = 0
		[Toggle(_COLORCUSTOMDATA)] _COLORCUSTOMDATA ("ColorCustomData", Float) = 0
		_Opacity ("Opacity", Range(0, 1)) = 1
		[Toggle(_VCAD)] _VCAD ("VCAD", Float) = 0
		[Toggle(_USETEXTURE)] _USETEXTURE ("UseTexture", Float) = 0
		[NoScaleOffset] _Texture2D ("Texture2D", 2D) = "white" {}
		_VertexAmount ("VertexAmount", Float) = 0
		_StepVertex ("StepVertex", Vector) = (0,0,0,0)
		_VertexSpeed ("VertexSpeed", Vector) = (0,0,0,0)
		_VertexScale ("VertexScale", Float) = 10
		_VertexTilling ("VertexTilling", Vector) = (1,1,0,0)
		[Toggle(_USEDSPLANCE)] _USEDSPLANCE ("UseDsplance", Float) = 0
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