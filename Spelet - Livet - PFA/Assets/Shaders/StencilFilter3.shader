﻿Shader "Custom/StencilFilter3"
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
            Ref 3
            Comp [_StencilTest]
        }

        Pass
        {
            
        }
    }
}
