using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour 
{
    void Update()
    {
        // press R to use the ReloadingScene method
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadingScene();
        }
    }

    void ReloadingScene()
    {
        // // 2) This uses the order defined in the Build Settings. You need to add the scene at "File/Build Settings/" for it to work.
        // // This is useful, when using an array to switch between scenes. But can cause problems, when you change the scene order.
        SceneManager.LoadScene(0);
    }
}
