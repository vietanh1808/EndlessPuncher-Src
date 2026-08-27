Shader "Fubu/Particles/Shield-Dash" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		_MainTex ("Main Tex", 2D) = "white" {}
		_Mask ("Mask", 2D) = "white" {}
		_Noise ("Noise", 2D) = "white" {}
		_SpeedMainTexUVNoiseZW ("Speed MainTex U/V + Noise Z/W", Vector) = (0,0,0,0)
		_Emission ("Emission", Float) = 2
		[Toggle] _UseFresnel ("Use Fresnel?", Float) = 1
		_Fresnel ("Fresnel", Float) = 1
		[Toggle] _Usesmoothcorners ("Use smooth corners?", Float) = 0
		_FresnelEmission ("Fresnel Emission", Float) = 1
		[Toggle] _SeparateFresnel ("SeparateFresnel", Float) = 0
		_SeparateEmission ("Separate Emission", Float) = 2
		_FresnelColor ("Fresnel Color", Vector) = (0.3568628,0.08627451,0.08627451,1)
		_FrontFacesColor ("Front Faces Color", Vector) = (0,0.2313726,1,1)
		_BackFacesColor ("Back Faces Color", Vector) = (0,0.02397324,0.509434,1)
		_BackFresnelColor ("Back Fresnel Color", Vector) = (0.3568628,0.08627451,0.08627451,1)
		[Toggle] _UseBackFresnel ("Use Back Fresnel?", Float) = 1
		_BackFresnel ("Back Fresnel", Float) = -2
		_BackFresnelEmission ("Back Fresnel Emission", Float) = 1
		[Toggle] _UseCustomData ("Use Custom Data?", Float) = 1
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
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
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}