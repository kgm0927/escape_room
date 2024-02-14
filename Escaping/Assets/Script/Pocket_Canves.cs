using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket_Canves : MonoBehaviour
{
    // Start is called before the first frame update

    public static List<Stuff> items;


    void Awake()
    {
        items= new List<Stuff>();
       
    }


    public void insert_pocket(Stuff st)
    {
        items.Add(st);
    }

   

    public List<Stuff> return_list()
    {
        return items;
    }





    // Update is called once per frame

}
