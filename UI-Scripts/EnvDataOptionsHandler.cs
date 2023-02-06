using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class EnvDataOptionsHandler : MonoBehaviour
{
    public ValueIndicator indicator;
    public Canvas updatecanvas;
    public FileReader FR;

    public void handleEnvDataOptions(string datatype)
    {
        indicator.EnvDataType = datatype;
        updatecanvas.gameObject.SetActive(true);
        FR.readEnvData();
    }
}
