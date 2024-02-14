using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


[System.Serializable]
public class Kitchen :Room
{

  
    protected string SceneName = "Kitchen";
    

    private void Awake()
    {
        base.arounds = FindObjectsOfType<Stuff>();
        
       
    }


}
