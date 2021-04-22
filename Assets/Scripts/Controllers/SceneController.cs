using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviourSingleton<SceneController>
{

    public List<CanvasGroup> Canvases;
    public Dictionary<string, CanvasGroup> Scenes;
    public CanvasGroup CurrentScene;

    // Start is called before the first frame update
    void Start()
    {
        SetupScenes();
       
            
    }


    void SetupScenes()
    {

        Scenes = new Dictionary<string, CanvasGroup>();

        foreach (CanvasGroup cg in Canvases) {

            Scenes.Add(cg.name, cg);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowScene(string sceneName)
    {

        if (CurrentScene != null) {
            CurrentScene.alpha = 0;
        }

        if (Scenes.ContainsKey(sceneName)) {

            CurrentScene = Scenes[sceneName];
            CurrentScene.alpha = 1;
        }

    }

    public void HideUI()
    {
        if (CurrentScene != null) {
            CurrentScene.alpha = 0;
        }
    }

    public void ShowUI()
    {
        if (CurrentScene != null) {
            CurrentScene.alpha = 1;
        }


    }


}
