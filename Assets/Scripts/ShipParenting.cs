using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ShipParenting : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            other.transform.parent = null;
        }
    }
}

