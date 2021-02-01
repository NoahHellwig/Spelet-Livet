Shader "Custom/PortalWindow10"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 10
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}
