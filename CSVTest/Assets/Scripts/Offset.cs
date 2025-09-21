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

    string GetKey()
    {
        return key;
    }

    Vector2 GetPosition()
    {
        return new Vector2(x, y);
    }


}
