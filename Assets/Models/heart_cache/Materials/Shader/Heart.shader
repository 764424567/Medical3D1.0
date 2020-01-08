// Shader created with Shader Forge v1.35 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.35;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:33748,y:32832,varname:node_4013,prsc:2|custl-2230-OUT,olwid-325-OUT,olcol-1025-OUT;n:type:ShaderForge.SFN_ToggleProperty,id:8688,x:32408,y:32361,ptovrint:False,ptlb:Hidden,ptin:_Hidden,varname:_Hidden,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False;n:type:ShaderForge.SFN_Vector1,id:2015,x:32393,y:32474,varname:node_2015,prsc:2,v1:1;n:type:ShaderForge.SFN_If,id:7108,x:32677,y:32430,varname:node_7108,prsc:2|A-8688-OUT,B-2015-OUT,GT-2015-OUT,EQ-6930-OUT,LT-2015-OUT;n:type:ShaderForge.SFN_LightVector,id:2237,x:32165,y:32740,varname:node_2237,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9444,x:32134,y:32601,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:8448,x:32380,y:32680,varname:node_8448,prsc:2,dt:4|A-9444-OUT,B-2237-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:752,x:32407,y:32865,varname:node_752,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2025,x:32567,y:32735,varname:node_2025,prsc:2|A-8448-OUT,B-752-OUT;n:type:ShaderForge.SFN_ViewReflectionVector,id:4278,x:32099,y:32955,varname:node_4278,prsc:2;n:type:ShaderForge.SFN_Dot,id:8769,x:32269,y:32952,varname:node_8769,prsc:2,dt:4|A-2237-OUT,B-4278-OUT;n:type:ShaderForge.SFN_Add,id:8060,x:32784,y:32896,varname:node_8060,prsc:2|A-2025-OUT,B-435-OUT;n:type:ShaderForge.SFN_Power,id:435,x:32601,y:32929,varname:node_435,prsc:2|VAL-8769-OUT,EXP-2804-OUT;n:type:ShaderForge.SFN_Exp,id:2804,x:32294,y:33107,varname:node_2804,prsc:2,et:0|IN-3333-OUT;n:type:ShaderForge.SFN_Vector1,id:3333,x:32124,y:33126,varname:node_3333,prsc:2,v1:6;n:type:ShaderForge.SFN_Tex2d,id:2624,x:32694,y:32195,ptovrint:False,ptlb:Main_map,ptin:_Main_map,varname:_Main_map,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:02eaf80d45c9ec74daeda5ff46457e20,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2230,x:33280,y:32860,varname:node_2230,prsc:2|A-4536-OUT,B-8060-OUT,C-7287-OUT;n:type:ShaderForge.SFN_Color,id:8009,x:33336,y:33549,ptovrint:False,ptlb:Outline_Cff,ptin:_Outline_Cff,varname:_Outline_Cff,prsc:0,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:0;n:type:ShaderForge.SFN_Multiply,id:325,x:33364,y:33360,varname:node_325,prsc:2|A-4886-OUT,B-1673-OUT;n:type:ShaderForge.SFN_Vector1,id:1673,x:33164,y:33522,varname:node_1673,prsc:2,v1:0.01;n:type:ShaderForge.SFN_ToggleProperty,id:4333,x:32793,y:33193,ptovrint:False,ptlb:selected,ptin:_selected,varname:_selected,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False;n:type:ShaderForge.SFN_Vector1,id:1626,x:32775,y:33561,varname:node_1626,prsc:2,v1:0.26;n:type:ShaderForge.SFN_Vector1,id:7119,x:32814,y:33495,varname:node_7119,prsc:2,v1:0;n:type:ShaderForge.SFN_If,id:4536,x:33158,y:33136,varname:node_4536,prsc:2|A-4333-OUT,B-7119-OUT,GT-428-OUT,EQ-2448-OUT,LT-2448-OUT;n:type:ShaderForge.SFN_Vector1,id:2448,x:32762,y:33246,varname:node_2448,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:428,x:32779,y:33360,varname:node_428,prsc:2,v1:1.65;n:type:ShaderForge.SFN_If,id:4886,x:33083,y:33327,varname:node_4886,prsc:2|A-4333-OUT,B-7119-OUT,GT-1626-OUT,EQ-7119-OUT,LT-7119-OUT;n:type:ShaderForge.SFN_Multiply,id:437,x:32924,y:32572,varname:node_437,prsc:2|A-2624-A,B-7108-OUT;n:type:ShaderForge.SFN_Multiply,id:7287,x:33063,y:32399,varname:node_7287,prsc:2|A-2624-RGB,B-437-OUT;n:type:ShaderForge.SFN_Vector1,id:6930,x:32406,y:32568,varname:node_6930,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:1025,x:33554,y:33759,varname:node_1025,prsc:2|A-8009-RGB,B-3688-OUT;n:type:ShaderForge.SFN_If,id:3688,x:33100,y:33760,varname:node_3688,prsc:2|A-4333-OUT,B-7119-OUT,GT-4333-OUT,EQ-7119-OUT,LT-7119-OUT;proporder:2624-8009-8688-4333;pass:END;sub:END;*/

Shader "Shader Forge/Heart" {
    Properties {
        _Main_map ("Main_map", 2D) = "bump" {}
        _Outline_Cff ("Outline_Cff", Color) = (0,0,0,0)
        [MaterialToggle] _Hidden ("Hidden", Float ) = 0
        [MaterialToggle] _selected ("selected", Float ) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 3.0
            uniform fixed4 _Outline_Cff;
            uniform fixed _selected;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float node_7119 = 0.0;
                float node_4886_if_leA = step(_selected,node_7119);
                float node_4886_if_leB = step(node_7119,_selected);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*(lerp((node_4886_if_leA*node_7119)+(node_4886_if_leB*0.26),node_7119,node_4886_if_leA*node_4886_if_leB)*0.01),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float node_7119 = 0.0;
                float node_3688_if_leA = step(_selected,node_7119);
                float node_3688_if_leB = step(node_7119,_selected);
                return fixed4((_Outline_Cff.rgb*lerp((node_3688_if_leA*node_7119)+(node_3688_if_leB*_selected),node_7119,node_3688_if_leA*node_3688_if_leB)),0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 3.0
            uniform fixed _Hidden;
            uniform sampler2D _Main_map; uniform float4 _Main_map_ST;
            uniform fixed _selected;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float node_7119 = 0.0;
                float node_4536_if_leA = step(_selected,node_7119);
                float node_4536_if_leB = step(node_7119,_selected);
                float node_2448 = 1.0;
                float4 _Main_map_var = tex2D(_Main_map,TRANSFORM_TEX(i.uv0, _Main_map));
                float node_2015 = 1.0;
                float node_7108_if_leA = step(_Hidden,node_2015);
                float node_7108_if_leB = step(node_2015,_Hidden);
                float3 finalColor = (lerp((node_4536_if_leA*node_2448)+(node_4536_if_leB*1.65),node_2448,node_4536_if_leA*node_4536_if_leB)*((0.5*dot(i.normalDir,lightDirection)+0.5*attenuation)+pow(0.5*dot(lightDirection,viewReflectDirection)+0.5,exp(6.0)))*(_Main_map_var.rgb*(_Main_map_var.a*lerp((node_7108_if_leA*node_2015)+(node_7108_if_leB*node_2015),0.0,node_7108_if_leA*node_7108_if_leB))));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 3.0
            uniform fixed _Hidden;
            uniform sampler2D _Main_map; uniform float4 _Main_map_ST;
            uniform fixed _selected;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float node_7119 = 0.0;
                float node_4536_if_leA = step(_selected,node_7119);
                float node_4536_if_leB = step(node_7119,_selected);
                float node_2448 = 1.0;
                float4 _Main_map_var = tex2D(_Main_map,TRANSFORM_TEX(i.uv0, _Main_map));
                float node_2015 = 1.0;
                float node_7108_if_leA = step(_Hidden,node_2015);
                float node_7108_if_leB = step(node_2015,_Hidden);
                float3 finalColor = (lerp((node_4536_if_leA*node_2448)+(node_4536_if_leB*1.65),node_2448,node_4536_if_leA*node_4536_if_leB)*((0.5*dot(i.normalDir,lightDirection)+0.5*attenuation)+pow(0.5*dot(lightDirection,viewReflectDirection)+0.5,exp(6.0)))*(_Main_map_var.rgb*(_Main_map_var.a*lerp((node_7108_if_leA*node_2015)+(node_7108_if_leB*node_2015),0.0,node_7108_if_leA*node_7108_if_leB))));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

