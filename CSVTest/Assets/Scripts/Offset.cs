using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class Offset
{
    //データのキーになるストリング
    public string key { set; get; }
    float x;
    float y;

    public Offset(string Key, float X, float Y)
    {
        key = Key;
        x = X;
        y = Y;
    }

    public string GetKey()
    {
        return key;
    }

    public Vector2 GetPosition()
    {
        return new Vector2(x, y);
    }


}
