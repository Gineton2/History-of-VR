using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Headsets : MonoBehaviour {
    public string headsetName;
    public float headsetCost;
    public bool controllerThreeDOF;
    public bool controllersSixDOF;
    public int headsetFOV;
    public float trackingArea;
    public bool baseStations;

    public Text headsetNameText;
    public Text headsetCostText;
    public Text controllerText;
    public Text headsetFOVText;
    public Text dofText;
    public Text baseStationsText;

    void Start() {
        gameObject.tag = "Headset";

        CreateUI();
    }

    // Generates text fields for UI
    void CreateUI() {
        // Set headset text
        headsetNameText.text = headsetName.ToString();

        // Set cost text
        headsetCostText.text = "Cost: $" + headsetCost.ToString() + ".";

        // Set controller text
        if (controllerThreeDOF) {
            controllerText.text = "3DOF Controllers.";
        }
        else if (controllersSixDOF) {
            controllerText.text = "6DOF Controllers.";
        }
        else {
            controllerText.text = "No controller.";
        }

        // Set FOV text
        headsetFOVText.text = "FOV: " + headsetFOV.ToString() + "°.";

        // Set trackable area and DoF text
        if (trackingArea <= 0) {
            dofText.text = "3DOF Headset tracking.";
        }
        else {
            dofText.text = 
                "6DOF Headset tracking.\n" +
                "Tracking area: " + trackingArea.ToString() + " m².";
        }

        // Basestation text
        if (baseStations) {
            baseStationsText.text = "Uses basestations for tracking.";  
        }
    }
}
