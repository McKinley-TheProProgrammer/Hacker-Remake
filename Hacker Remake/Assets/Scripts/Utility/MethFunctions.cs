using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MethFunctions 
{
    /// <summary>
    /// Retorna um valor entre a e b baseado em um valor t = [0,1]
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static float Lerp(float a, float b, float t)
    {
        t = Mathf.Clamp01(t);
        return a + t * (b - a);
    }

    /// <summary>
    /// Retorna a porcentagem/limiar entre 0 e 1 de acordo com um valor a e b/ min e max
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public static float InverseLerp(float min, float max, float v)
    {
        return (v - min) / (max - min);
    }

    public static float Remap(float inMin, float inMax, float outMin,float outMax, float v)
    {
        float t = InverseLerp(inMin, inMax, v);
        return Lerp(outMin, outMax, t);
    }
}
