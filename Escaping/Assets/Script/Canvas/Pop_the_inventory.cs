using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pop_the_inventory : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isOverlayActive = false;

    void Update()
    {
        // 버튼을 눌렀을 때 씬을 로드합니다.
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!isOverlayActive)
            {
                LoadOverlayScene();
            }
            else
            {
                UnloadOverlayScene();
            }
        }
    }

    void LoadOverlayScene()
    {
        // 현재 씬 위에 새로운 씬을 로드합니다.
        UnityEngine.SceneManagement.SceneManager.LoadScene("Canvas", LoadSceneMode.Additive);
        isOverlayActive = true;
    }

    void UnloadOverlayScene()
    {
        // 새로운 씬을 언로드합니다.
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Canvas");
        isOverlayActive = false;
    }

}
