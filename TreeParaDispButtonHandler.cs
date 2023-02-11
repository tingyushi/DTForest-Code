using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeParaDispButtonHandler : MonoBehaviour
{
    private bool isActive = false;
    public Image TreeParamDisp;

    public void TreeParamDispHandle()
    {
        if(!isActive)
        {
            TreeParamDisp.gameObject.SetActive(true);
            isActive = !isActive;
        }
        else
        {
            TreeParamDisp.gameObject.SetActive(false);
            isActive = !isActive;
        }
    }
}
