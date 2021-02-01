Shader "Custom/PortalWindow7"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 7
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}