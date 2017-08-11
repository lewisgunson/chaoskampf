using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rays : MonoBehaviour {

    public List<Transform> inputs = new List<Transform> ();

    public List<Color> colors = new List<Color> ();

    void Awake() {
        if (colors.Count == 0) {
            Color col = Color.black;
            col.a = 0;
            colors.Add (col);
        }
    }
	
	// Update is called once per frame
	void Update () {
        int idxColor = 0;
        foreach (Transform input in inputs) {
            Debug.DrawRay (input.position, input.forward, colors[idxColor]);

            idxColor++;
            if (idxColor >= colors.Count) {
                idxColor = 0;
            }
        }
	}
}
