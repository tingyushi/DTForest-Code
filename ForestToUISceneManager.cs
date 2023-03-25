using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestToUISceneManager : MonoBehaviour
{
    public treePlanting treePlanter;

    public void Plot14ToMain()
    {
        SceneManager.UnloadScene(1);
        treePlanter.cleanTrees();
    }
}
