using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AsciiLevel0Loader : MonoBehaviour
{

    public string levelTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        string filepath = Application.dataPath + levelTxt; //path to file

        if (!File.Exists(filepath))
        {
            File.WriteAllText(filepath, "X");
        }
        
        string[] inputLines = File.ReadAllLines(filepath);

        for (int y = 0; y < inputLines.Length; y++) //loop through each line
        {
            string line = inputLines[y]; //var for the line we're currently looping through

            for(int x = 0; x < line.Length; x++) //loop through each character in each the line
            {
                GameObject tile;
                
                switch (line[x])
                {
                    case 'X': //if the character in a given line is equal to X
                        tile = Instantiate(Resources.Load<GameObject>("Prefabs/Wall")); //make a wall
                        break;
                    default: //if the character in a given line does not match any above cases
                        tile = null; //don't make anything
                        break;
                }

                if (tile != null) //if a tile exists
                {
                    tile.transform.position = new Vector3(x - line.Length/2f, inputLines.Length/2f - y, 0.78f);
                    //move that tile to a position relative to it's location in the .txt file
                    //convert origin in scene from center of screen
                }
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
