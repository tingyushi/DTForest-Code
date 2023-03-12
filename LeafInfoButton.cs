using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafInfoButton : MonoBehaviour
{
    public bool isActive = false;
    public Text TreeParamDisplay;
    public Text LeafInfoDisplay;

    public void ChangeView()
    {
        if (!isActive)
        {
            isActive = !isActive;
            LeafInfoDisplay.gameObject.SetActive(true);
            TreeParamDisplay.gameObject.SetActive(false);
        }
        else
        {
            isActive = !isActive;
            LeafInfoDisplay.gameObject.SetActive(false);
            TreeParamDisplay.gameObject.SetActive(true);
        }
    }
}
