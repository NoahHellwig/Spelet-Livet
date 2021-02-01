Shader "Custom/PortalWindow12"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 12
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}
