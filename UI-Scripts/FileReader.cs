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
        int plotNumber = indicator.plotNumber;

        string filePath;

        // no file to read
        if(plotNumber == 0)
        {
            currentValueDisp.text = "Please select a plot";
            return;
        }

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
            currentValueDisp.text =  "Current Humidity: " + JsonModelObj.envData.Humility;
        }
        else if (indicator.EnvDataType.Equals("Temp"))
        {
            currentValueDisp.text = "Current Temperature: " + JsonModelObj.envData.Temp;
        }
        else if (indicator.EnvDataType.Equals("SCContent"))
        {
            currentValueDisp.text = "Current Soil Carbon Contents: " + JsonModelObj.envData.SCContent;
        }
        else if (indicator.EnvDataType.Equals("SNContent"))
        {
            currentValueDisp.text = "Current Soil Nitrogen Contents: " + JsonModelObj.envData.SNContent;
        }
        else
        {
            currentValueDisp.text = "Current LAI: " + JsonModelObj.envData.LAI;
        }
    }


    public void readTreeParam()
    {
        int plotNumber = indicator.plotNumber;

        string filePath;

        // no file to read
        if(plotNumber == 0)
        {
            currentValueDisp.text = "Please select a plot";
            return;
        }

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
                currentValueDisp.text = "Current Density: " + JsonModelObj.redPine.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redPine.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redPine.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redPine.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("Oak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.oak.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " +  JsonModelObj.oak.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.oak.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.oak.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("Beech"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.beech.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.beech.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.beech.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.beech.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("Birch"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.birch.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.birch.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.birch.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.birch.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("RedMaple"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.redMaple.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redMaple.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redMaple.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redMaple.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("WhitePine"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.whitePine.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.whitePine.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.whitePine.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.whitePine.Age;
            }
            return;
        }

        if (indicator.TreeType.Equals("RedOak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.redOak.Density;
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redOak.DBH;
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redOak.Height;
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redOak.Age;
            }
            return;
        }
    }

    public void clearText()
    {
        currentValueDisp.text = "";
    }
}