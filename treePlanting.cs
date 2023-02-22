using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class treePlanting : MonoBehaviour
{
    // a pool for the trees
    private List<GameObject> trees = new List<GameObject>();

    /*
     * define the number of trees in each plot.
     * The last number means the average number of trees in 14 plots.
     */
    private int[] plotTreeNumbers = { 178, 235, 178, 213, 432, 432, 213, 118, 235, 118, 178, 235, 213, 432, 243};

    /*
     * define heights of different tree models when scale is one
     * HSR : height scal ratio
     * Unit: meter
     */
    private double redPineHSR = 25.0;         private double oakHSR = 17.2 / 2;
    private double beechHSR = 35.47 / 2;      private double birchHSR = 22.18 / 2;
    private double redMapleHSR = 14.12 / 2;   private double whitePineHSR = 64.4 / 2;
    private double redOakHSR = 18.95 / 2;

    /*
     * Define plot information
     */
    private double sideLength = 100.0;
    private float startingCoordinate = 1f;
    private float endingCoordinate = 99f;
    

    // a collection of tree positions
    private Vector3[] treelocal;

    // including all the data about the plot
    public DataModel data;


    /*
     * A list that contains all the tree model prefabs
     * Index 0 --> Red Pine
     * Index 1 --> Oak
     * Index 2 --> Beech
     * Index 3 --> Birch
     * Index 4 --> Red Maple
     * Index 5 --> White Pine
     * Index 6 --> Red Oak
     */
    public List<GameObject> treeprefabs;


    private int[] calculatedTreeNumbers()
    {
        double area = sideLength * sideLength;

        int[] treenumbers = {
            Convert.ToInt32( Convert.ToDouble(data.RedPineData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.OakData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.BeechData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.BirchData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.RedMapleData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.WhitePineData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.RedOakData.Density) * area ),
        };
        return treenumbers;
    }

    private void generateSquareLocation(int numberOfPoints)
    {
        treelocal = new Vector3[numberOfPoints];

        int i;

        for (i = 0; i < treelocal.Length; i++)
        {
            /*
             * The second parameter in the Vectors is related to the height, we need to somehow
             * get it from the heightmap of the terrain.
             */
            treelocal[i] = new Vector3(UnityEngine.Random.Range(startingCoordinate, endingCoordinate),
                                       0f,
                                       UnityEngine.Random.Range(startingCoordinate, endingCoordinate));
        }
    }

    private void generateCircleLocation(double x1, double y1, double r1, double x2, double y2, double r2, int numberOfPoints)
    {

    }

    private double distance(double x1, double y1, double x2, double y2)
    {
        return 0.0;
    }

    public void cleanTrees()
    {
        if (trees.Count == 0)
        {
            return;
        }
        trees.ForEach(it => { Destroy(it); });
        trees.Clear();
    }


    public void plantTrees(int plotNumberIndex)
    {
        //first step: clean the trees from the previous plot
        cleanTrees();

        /*
         * Second step: calculate the number of trees for different types of trees
         * Index 0 --> Red Pine
         * Index 1 --> Oak
         * Index 2 --> Beech
         * Index 3 --> Birch
         * Index 4 --> Red Maple
         * Index 5 --> White Pine
         * Index 6 --> Red Oak
         */
        int[] differentTreeNumbers = calculatedTreeNumbers();

        Debug.Log("The number of trees is : " + differentTreeNumbers.Sum().ToString());

        /*
        * Third step: generate tree locations
        */
        generateSquareLocation(differentTreeNumbers.Sum());


        int posIndex = 0;
        double treeHeight;
        double standardScale;
        float lowerBound;
        float upperBound;


        /*
         * Plant Red Pines
         */
        treeHeight = Convert.ToDouble(data.RedPineData.Height);
        standardScale = treeHeight / redPineHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[0]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[0]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Oak Trees
         */
        treeHeight = Convert.ToDouble(data.OakData.Height);
        standardScale = treeHeight / oakHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[1]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[1]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Beech Trees
         */
        treeHeight = Convert.ToDouble(data.BeechData.Height);
        standardScale = treeHeight / beechHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[2]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[2]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Birch Trees
         */
        treeHeight = Convert.ToDouble(data.BirchData.Height);
        standardScale = treeHeight / birchHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[3]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[3]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Red Maple
         */
        treeHeight = Convert.ToDouble(data.RedMapleData.Height);
        standardScale = treeHeight / redMapleHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[4]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[4]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant White Pine
         */
        treeHeight = Convert.ToDouble(data.WhitePineData.Height);
        standardScale = treeHeight / whitePineHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[5]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[5]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }

        /*
         * Plant Red Oak
         */
        treeHeight = Convert.ToDouble(data.RedOakData.Height);
        standardScale = treeHeight / redOakHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[6]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[6]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

            //modity color here
            treeinstance.GetComponent<Renderer>().materials[1].color = new Color32(194, 31, 48, 255);

            trees.Add(treeinstance);
            posIndex++;
        }
    }

}