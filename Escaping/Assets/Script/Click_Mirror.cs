using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Mirror : Move_to_scene
{
    private new string  scene_name="Mirror";
    private void Awake()
    {
        base.scene_name = scene_name;
    }

    public override void Move_the_Area(string name)
    {
        base.Move_the_Area(name);
    }
}
