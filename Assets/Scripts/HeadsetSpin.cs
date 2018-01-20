using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsetSpin : MonoBehaviour {

    public float spinRate;

    private GameObject[] headsets;
    private GameObject[] threeDofControllers;
    private GameObject[] sixDofControllers;
	// Use this for initialization
	void Start ()
    {
        headsets = GameObject.FindGameObjectsWithTag("Headset");
        threeDofControllers = GameObject.FindGameObjectsWithTag("3DofController");
        sixDofControllers = GameObject.FindGameObjectsWithTag("6DofController");
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (GameObject headset in headsets)
        {
            headset.transform.Rotate(Vector3.up * spinRate * Time.deltaTime, Space.World);
        }

        // TODO Add animations for 3DOF and 6DOF controllers
        foreach (GameObject controller in threeDofControllers) {
            //controller.transform.Rotate(Vector)
        }
	}
}
