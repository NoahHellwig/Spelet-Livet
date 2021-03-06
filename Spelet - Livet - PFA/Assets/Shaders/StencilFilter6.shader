﻿Shader "Custom/StencilFilter6"
{
    Properties 
    {
        _Color ("Color", Color) = (1,1,1,1)
        [Enum(Equal,4,NotEqual,5)] _StencilTest ("Stencil Test", int) = 4
    }
    SubShader
    {
        Color [_Color]
        Stencil{
            Ref 6
            Comp [_StencilTest]
        }

        Pass
        {
            
        }
    }
}