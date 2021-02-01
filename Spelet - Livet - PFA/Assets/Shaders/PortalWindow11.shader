Shader "Custom/PortalWindow11"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 11
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}