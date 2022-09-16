using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapToSceneScript : MonoBehaviour
{
    [SerializeField]List<string> scenesToLoad = new List<string>();

    public void LoadMyScenes()
    {
        List<AsyncOperation> newScenes = new List<AsyncOperation>();
        for (int i = 0; i < scenesToLoad.Count; i++)
        {
            if (i > 0)
            {
                newScenes.Add(SceneManager.LoadSceneAsync(scenesToLoad[i], LoadSceneMode.Additive));
            }
            else
            {
                newScenes.Add(SceneManager.LoadSceneAsync(scenesToLoad[i]));
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The Player has Quit the Game!");
    }
}
