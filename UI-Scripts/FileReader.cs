using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class FileReader : MonoBehaviour
{
    public ValueIndicator indicator;
    private JsonModel JsonModelObj;
    public Text currentValueDisp;

    public void readEnvData()
    {
        string temp = "";

        int plotNumber = indicator.plotNumber;

        string filePath;

        if (plotNumber == 15)
        {
            filePath = "./dataCenter/overalldata.json";
        }
        else
        {
            filePath = "./dataCenter/plot" + plotNumber.ToString() + "data.json";
        }

        string plotJsonData = File.ReadAllText(filePath);

        JsonModelObj = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel>(plotJsonData);

        if (indicator.EnvDataType.Equals("Humility"))
        {
            temp =  JsonModelObj.envData.Humility;
        }
        else if (indicator.EnvDataType.Equals("Temp"))
        {
            temp = JsonModelObj.envData.Temp;
        }
        else if (indicator.EnvDataType.Equals("SCContent"))
        {
            temp = JsonModelObj.envData.SCContent;
        }
        else if (indicator.EnvDataType.Equals("SNContent"))
        {
            temp = JsonModelObj.envData.SNContent;
        }
        else
        {
            temp = JsonModelObj.envData.LAI;
        }
        currentValueDisp.text = "Current Value: " + temp;
    }


    public void readTreeParam()
    {
        string temp = "";

        int plotNumber = indicator.plotNumber;

        string filePath;

        if (plotNumber == 15)
        {
            filePath = "./dataCenter/overalldata.json";
        }
        else
        {
            filePath = "./dataCenter/plot" + plotNumber.ToString() + "data.json";
        }

        string plotJsonData = File.ReadAllText(filePath);

        JsonModelObj = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel>(plotJsonData);

        if (indicator.TreeType.Equals("RedPine"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.redPine.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.redPine.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.redPine.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.redPine.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("Oak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.oak.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.oak.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.oak.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.oak.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("Beech"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.beech.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.beech.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.beech.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.beech.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("Birch"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.birch.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.birch.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.birch.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.birch.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("RedMaple"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.redMaple.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.redMaple.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.redMaple.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.redMaple.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("WhitePine"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.whitePine.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.whitePine.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.whitePine.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.whitePine.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }

        if (indicator.TreeType.Equals("RedOak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                temp = JsonModelObj.redOak.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                temp = JsonModelObj.redOak.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                temp = JsonModelObj.redOak.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                temp = JsonModelObj.redOak.Age;
            }
            currentValueDisp.text = "Current Value: " + temp;
            return;
        }
    }

    public void clearText()
    {
        currentValueDisp.text = "";
    }
}