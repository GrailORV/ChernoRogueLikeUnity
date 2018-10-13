using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreateManager : MonoBehaviour {

    [SerializeField] TextAsset csvFile;

    private List<string[]> csvDatas = new List<string[]>();
    private int csvHeight = 0;

	// Use this for initialization
	void Start () {
		
	}
}
