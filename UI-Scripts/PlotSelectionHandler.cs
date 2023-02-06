using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotSelectionHandler : MonoBehaviour
{
    public Dropdown plotSelect;
    public ValueIndicator indicator;
    public FileReader FR;

    public void PlotDropDownHandler()
    {
        indicator.plotNumber = plotSelect.value;
        if (indicator.isEnvData)
        {
            FR.readEnvData();
        }
        if (indicator.isTreeParam)
        {
            FR.readTreeParam();
        }
    }
}
