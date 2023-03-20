using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SeasonController : MonoBehaviour
{
    public bool haveLeaves = true;
    public treePlanting treePlanter;
    public Dropdown plotSelection;
    public Button seasonChangeBut;
    public Sprite summerImage;
    public Sprite winterImage;

    public void Awake()
    {
        seasonChangeBut.image.sprite = summerImage;
    }

    public void changeSeason()
    {   
        haveLeaves = !haveLeaves;
        if (haveLeaves)
        {
            seasonChangeBut.image.sprite = summerImage;
        }
        if (!haveLeaves)
        {
            seasonChangeBut.image.sprite = winterImage;
        }

        treePlanter.plantTrees(plotSelection.value);
    }
}
