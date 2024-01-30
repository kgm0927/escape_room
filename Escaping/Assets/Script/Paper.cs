using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paper : Stuff
{
    private string name = "Paper";
    private bool water_fulled = false;
  
    Move_to_bedroom move;
  
   
    // Start is called before the first frame update
    private void Awake()
    {
        stuff = GameObject.Find(name);
        base.stuff = this.stuff;
        move=GetComponent<Move_to_bedroom>();
    }

    public override void delete_self()
    {
        

        move.Move_the_Area(move.Scene());
        base.delete_self();
    }

    public override Stuff return_self()
    {
        return base.return_self();
    }

}
