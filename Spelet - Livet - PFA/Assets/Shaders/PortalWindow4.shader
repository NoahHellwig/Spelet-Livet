﻿Shader "Custom/PortalWindow4"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 4
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}