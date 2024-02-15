using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : Stuff
{
    // Start is called before the first frame update


    private string name = "Match_in_pocket";

    private void Awake()
    {
        stuff = GameObject.Find(name);
        base.stuff = this.stuff;
        base.room = FindObjectOfType<Room>();
    }

    // Update is called once per frame
   
}
