Shader "Custom/PortalWindow3"
{
   
    SubShader
    {
        ZWrite off
        ColorMask 0
        Cull off

        Stencil{
            Ref 3
            //Pass replace 
            Pass replace
        }
        Pass
        {
            
        }
    }
}
