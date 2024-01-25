using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to_2F : Move_to_scene
{
    // Start is called before the first frame update
    private new string scene_name = "2F";

    private void Awake()
    {
        base.scene_name = scene_name;
    }

    protected override void Move_the_Area(string name)
    {
        base.Move_the_Area(name);
    }

}
