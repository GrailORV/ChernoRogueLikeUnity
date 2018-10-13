using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapCreateManager : MonoBehaviour {

    [SerializeField] TextAsset csvFile;

    string str = "";

    private int Vertical = 9;
    private int Horizontal = 19;

    enum MAPOBJ
    {
        plane,
        wall,
        player,
        enemy,
        item,
        exit
    }
    

    // Use this for initialization
    void Start()
    {
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            str = str + line;
        }

        str = str + ",";
    }
}
