using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Make this a template called Last<Type> // It remembers its last value and sends message on change
public class SmartBool : MonoBehaviour {

    public bool val;
    bool lastVal;

	// Use this for initialization
	void Start () {
        lastVal = val;
	}
	
	// Update is called once per frame
	void Update () {
        if (lastVal != val) {
            /// TODO: Fire delegate
        }

        lastVal = val;
	}
}
