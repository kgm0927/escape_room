using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Front_mirror : Room
{
    private new string scen_name = "Mirror";
    private void Awake()
    {
        base.arounds = FindObjectsOfType<Stuff>();
    }
}
