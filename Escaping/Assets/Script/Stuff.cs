using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuff : MonoBehaviour
{

    protected GameObject stuff; // 이걸 파괴해야만 게임 오브젝트가 사라진다.
    public Room room;
    static public bool exist_or_not = true;

    // Start is called before the first frame update

  


    private void OnMouseDown()
    {
        room.check_the_stuff(return_self());
        delete_self();
    }

    virtual public Stuff return_self()
    {
        return this;
    }

    virtual public GameObject return_object()
    {
        return stuff;
    }

    virtual public void delete_self()
    {

        Destroy(stuff);

    }

    public void change_exist_or_not()
    {
        exist_or_not = false;
    }


   public  bool exist_return()
    {
        return exist_or_not;
    }
  

}
