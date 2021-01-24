Shader "Custom/PortalWindow6"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 6
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}