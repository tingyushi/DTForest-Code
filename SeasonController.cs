using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SeasonController : MonoBehaviour
{
    public bool haveLeaves = true;
    public treePlanting treePlanter;
    public Dropdown plotSelection;

    public void changeSeason()
    {
        haveLeaves = !haveLeaves;
        treePlanter.plantTrees(plotSelection.value);
    }
}
