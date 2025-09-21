using System.Collections.Generic;
using UnityEngine;

public class Act
{
    public string key { set; get; }

    public List<string> scenes = new List<string>();

    public Act(string Key, List<string> Scenes)
    {
        key = Key;
        scenes = Scenes;
    }

    public List<string> GetScenes()
    {
        return scenes;
    }
}
