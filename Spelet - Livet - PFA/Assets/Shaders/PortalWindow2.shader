Shader "Custom/PortalWindow2"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 2
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}
