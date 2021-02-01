Shader "Custom/PortalWindow13"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 13
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}