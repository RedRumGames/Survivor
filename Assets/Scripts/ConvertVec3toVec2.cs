using UnityEngine;
using System.Collections;

public static class ConvertVec3toVec2
{
    public static Vector2 tovector2(this Vector3 vec3)
    {
        return new Vector2(vec3.x, vec3.y);
    }
}
