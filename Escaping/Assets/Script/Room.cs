using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Room : MonoBehaviour
{
    // Start is called before the first frame update
     public Stuff []arounds;
    // 주변에 어디 있는지 알 수 있게 함.
  


    private void Awake()
    {
    
    }


    private void Update()
    {
   ;
        
        for (int i = 0; i < arounds.Length; i++)
        {
            if (!arounds[i].exist_return())
            {
                Destroy(arounds[i].return_object());
            }
        }
    }


    public void check_the_stuff(Stuff obj)
    {

        for (int i = 0; i < arounds.Length; i++)
        {
            if (arounds[i].GetType() == obj.GetType())
            {
                arounds[i].change_exist_or_not();
             
                arounds[i].delete_self();
            }
        }

        // 여기서 방 안에 있는 물질을 클릭하면 배열 안에 있는 것이
        // 삭제되도록 함.
        //
    }

}
