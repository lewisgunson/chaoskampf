using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoMover : MonoBehaviour {

    public Transform input;
    public Transform output;

    CharacterController outCharCtrl;

    public float targetSpeed = 3f;

    public bool canFly; // Default = false
    float groundHeight;

    public bool moveToGround;


    void Awake() {
        outCharCtrl = output.GetComponent <CharacterController>();

        if (moveToGround) {
            MoveToGround ();
        }
    }

	
	// Update is called once per frame
	void Update () {
        Vector3 forward = new Vector3 (input.forward.x, input.forward.y, input.forward.z).normalized;

        if (!canFly) {
            forward.y = 0;
        }

        Vector3 velocity = forward * targetSpeed * Time.deltaTime;

        if (outCharCtrl != null) {
            outCharCtrl.Move (velocity);
        } else {
            output.Translate (velocity, Space.World);
        }

        if (moveToGround) {
            MoveToGround ();
        }
	}

    void MoveToGround() { // This function assumes global space
        RaycastHit hit;
        if (Physics.Raycast (output.position, Vector3.down, out hit)) {
            Vector3 pos = output.position;
            pos.y = hit.point.y;
            output.position = pos;
        }

        moveToGround = false;
    }
}
