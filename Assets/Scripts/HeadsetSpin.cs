using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsetSpin : MonoBehaviour {

    public float spinRate;

    private GameObject[] headsets;
	// Use this for initialization
	void Start ()
    {
        headsets = GameObject.FindGameObjectsWithTag("Headset");
	}
	
	// Update is called once per frame
	void Update ()
    {
        foreach (GameObject headset in headsets)
        {
            headset.transform.Rotate(Vector3.up, spinRate * Time.deltaTime);
        }
	}
}
