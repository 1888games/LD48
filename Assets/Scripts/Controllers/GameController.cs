using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviourSingleton<GameController>
{
    // Start is called before the first frame update
    void Start()
    {
        SceneController.Instance.ShowScene("Title");
    }

    // Update is called once per frame
    void Update()
    {
        CheckQuit();
    }

    void CheckQuit()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }

    }
}
