Shader "Hidden/VolumetricFog2/DistantFog" {
	Properties {
		[HideInInspector] _MainTex ("Noise Texture", 2D) = "white" {}
		[HideInInspector] _Color ("Color", Vector) = (1,1,1,1)
		[HideInInspector] _DistantFogData ("Distant Fog Data", Vector) = (100,0.1,400,0.5)
		[HideInInspector] _LightColor ("Light Color", Vector) = (1,1,1,1)
		[HideInInspector] _LightDiffusionPower ("Sun Diffusion Power", Range(1, 64)) = 32
		[HideInInspector] _LightDiffusionIntensity ("Sun Diffusion Intensity", Range(0, 1)) = 0.4
		[HideInInspector] _SunDir ("Sun Direction", Vector) = (1,0,0,1)
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
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}