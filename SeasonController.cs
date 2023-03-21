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
    public ParticleSystem Snow;

    public void Awake()
    {
        seasonChangeBut.image.sprite = summerImage;
        Snow.gameObject.SetActive(false);
    }

    public void changeSeason()
    {   
        haveLeaves = !haveLeaves;
        if (haveLeaves)
        {
            Snow.gameObject.SetActive(false);
            seasonChangeBut.image.sprite = summerImage;
        }
        if (!haveLeaves)
        {
            Snow.gameObject.SetActive(true);
            seasonChangeBut.image.sprite = winterImage;
        }

        treePlanter.plantTrees(plotSelection.value);
    }
}
