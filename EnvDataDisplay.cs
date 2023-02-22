using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvDataDisplay : MonoBehaviour
{

    public DataModel DataModelObj;

    public Text EnvDisp;

    private string s1, s2, s3, s4, s5;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    public void exactEnvData()
    {
        s1 = "  Humidity: " + DataModelObj.EnvData.Humility + " %\n\n";
        s2 = "  Temperature: " + DataModelObj.EnvData.Temp + " C\n\n";
        s3 = "  Soil C Content: " + DataModelObj.EnvData.SCContent + "\n\n";
        s4 = "  Soil N Content: " + DataModelObj.EnvData.SNContent + "\n\n";
        s5 = "  LAI: " + DataModelObj.EnvData.LAI;

        EnvDisp.text = s1 + s2 + s3 + s4 + s5;
    }
}
