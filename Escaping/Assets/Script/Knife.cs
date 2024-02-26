using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Stuff
{
    // Start is called before the first frame update
    void Start()
    {
        base.r2 = GetComponent<Rigidbody2D>();
        base.stuff = base.r2.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
