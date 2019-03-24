using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AsciiLevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string filepath = Application.dataPath + "/level0.txt"; //path to file

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
                //insert switch statements here
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
