using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cup : Stuff
{

    private string name = "cup";
    private bool water_fulled=false;
   
  
    // Start is called before the first frame update
    private void Awake()
    {
        
        stuff = GameObject.Find(name);
        base.stuff = this.stuff;
        base.room=FindObjectOfType<Room>();
    }
    
    public override Stuff return_self()
    {
        return base.return_self();
    }

    public override void delete_self()
    {
       
        base.delete_self();
    }





    }
