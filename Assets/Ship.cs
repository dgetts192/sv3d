using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Ship : NetworkBehaviour {

    public float shipTopSpeed = 10;
    public Vector3 shipCurrVelocity;
    public bool beingPiloted = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(shipCurrVelocity);
    }
    
}
