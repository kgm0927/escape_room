using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_to_scene : MonoBehaviour
{
    // Start is called before the first frame update
    protected string scene_name;

    virtual public void Move_the_Area(string name)
    {
        SceneManager.LoadScene(name);
    }


    virtual public string Scene()
    {
        return scene_name;
    }

    private void OnMouseDown()
    {
        Move_the_Area(scene_name);
    }

}
