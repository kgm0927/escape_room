using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cup : Stuff
{

    private new string name = "cup";
    static private bool water_fulled=false;
   
  
    // Start is called before the first frame update
  
     private void Awake()
    {

        base.r2 = GetComponent<Rigidbody2D>();
        base.stuff = base.r2.gameObject;
        base.room=FindObjectOfType<Room>();
        base.spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public override Stuff return_self()
    {
        return base.return_self();
    }

    public override void delete_self()
    {
       
        base.delete_self();
    }

    public bool water_is_fulled()
    {
        return water_fulled;
    }


    


    }
