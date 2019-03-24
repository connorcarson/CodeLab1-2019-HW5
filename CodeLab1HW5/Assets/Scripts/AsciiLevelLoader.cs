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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
