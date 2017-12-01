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

    public Text headsetNameText;
    public Text headsetCostText;
    public Text controllerText;
    public Text headsetFOVText;
    public Text dofText;

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
            controllerText.text = "Controller with rotational tracking";
        }
        else if (controllersSixDOF) {
            controllerText.text = "Controllers with positional and rotational tracking.";
        }
        else {
            controllerText.text = "No controller.";
        }

        // Set FOV text
        headsetFOVText.text = "FOV: " + headsetFOV.ToString() + "°.";

        // Set trackable area and DoF text
        if (trackingArea <= 0) {
            dofText.text = "Headset rotational tracking only.";
        }
        else {
            dofText.text = 
                "Headset positional and rotational tracking.\n" +
                "Tracking area: " + trackingArea.ToString() + " m².";
        }
    }
}
