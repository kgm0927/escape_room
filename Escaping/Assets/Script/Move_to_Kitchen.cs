using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to_Kitchen : Move_to_scene
{
    // Start is called before the first frame update
    private new string scene_name = "Kitchen";
    public Cup cup;



    private void Awake()
    {
        base.scene_name = scene_name;
      

    }

    public override void Move_the_Area(string name)
    {
        base.Move_the_Area(name);
        
    }
    

}
