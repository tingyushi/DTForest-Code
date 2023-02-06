using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TreeParamOptionsHandler : MonoBehaviour
{
    public ValueIndicator indicator;
    public Canvas updatecanvas;
    public FileReader FR;

    public void handleTreeParamOptions(string datatype)
    {
        indicator.TreeParamType = datatype;
        updatecanvas.gameObject.SetActive(true);
        FR.readTreeParam();
    }
}
