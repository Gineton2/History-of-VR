using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Headsets : MonoBehaviour {
    public string headsetName;
    public float headsetCost;
    public bool sixDOF;
    public bool controllerThreeDOF;
    public bool controllersSixDOF;
    public int headsetFOV;
    public float trackableArea;

    void Start()
    {
        gameObject.tag = "Headset";
    }
}
