using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class on_fire : MonoBehaviour
{

    Stuff[] making_fire;
    private bool exist_match = false;
    private bool exist_paper = false;
    
    private void Awake()
    {
        making_fire = new Stuff[2]; 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Put_the_paper(collision);
        Put_the_fired_match(collision);
        

        if((!exist_match)&& exist_paper)// 성냥은 아직 쓰지 않았고, 종이만 있는 경우
        {
            // 구겨진 종이가 놓여짐.
        }
        else if (exist_match && exist_match)// 구겨진 종이가 놓이고, 성냥이 들어갈 경우.
        {
            // 불이 피워짐.


        }
        else if ((collision.GetType() is Cup)) // 물컵을 넣을 경우
        {
            Cup cup=collision.collider.GetComponent<Cup>();
            if (cup.water_is_fulled())// 만약 물컵에 물이 담겨져 있다면,
            {
                // 불이 꺼지고 칼이 나타남.
            }
            
        }




    }

    private void Put_the_paper(Collision2D c)
    {
        if(c.GetType() is Paper)
        {
            making_fire[0]=c.collider.GetComponent<Paper>();
             exist_paper = true;
        }
    }

    private void Put_the_fired_match(Collision2D c)
    {
        if(c.GetType() is Match)
        {
            making_fire[1]=c.collider.GetComponent<Match>();
            exist_match = true;
        }
    }

}
