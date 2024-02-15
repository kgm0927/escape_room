using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedroom : Room
{
    // Start is called before the first frame update

    protected string SceneName = "bedroom";
    private void Awake()
    {
        base.arounds = FindObjectsOfType<Stuff>(); 
    }
}
