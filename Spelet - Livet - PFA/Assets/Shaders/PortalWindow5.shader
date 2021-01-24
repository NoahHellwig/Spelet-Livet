Shader "Custom/PortalWindow5"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 5
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}