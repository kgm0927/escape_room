using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to_paper : Move_to_scene
{
    // Start is called before the first frame update


    private new string scene_name = "Knife_paper";
    private void Awake()
    {
        base.scene_name = scene_name;
    }

    public override string Scene()
    {
        return base.Scene();
    }
    public override void Move_the_Area(string name)
    {
        base.Move_the_Area(name);
    }
}
