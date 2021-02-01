Shader "Custom/PortalWindow9"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 9
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}
