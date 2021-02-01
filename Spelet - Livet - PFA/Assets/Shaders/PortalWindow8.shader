Shader "Custom/PortalWindow8"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 8
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}