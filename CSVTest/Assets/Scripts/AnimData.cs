using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class AnimData
{
    public string key { set; get; }

    List<string> AnimPath = new List<string>();

    public AnimData(string Key, List<string> strings)
    {
        key = Key;
        AnimPath = strings;
    }

    public List<string> GetAnimPathList()
    {
        return AnimPath;
    }
}
