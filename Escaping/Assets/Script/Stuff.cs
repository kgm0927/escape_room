using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuff : MonoBehaviour
{

    protected GameObject stuff;



    // Start is called before the first frame update
    private void OnMouseDown()
    {
        delete_self();
    }

    virtual public Stuff return_self()
    {


        return this;

    }

    virtual public void delete_self()
    {
        Destroy(stuff);
        
    }




}
