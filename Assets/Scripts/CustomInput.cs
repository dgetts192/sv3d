using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class CustomInput : NetworkBehaviour {

    [SerializeField] public bool canInteract;
    [SerializeField] public Transform currInteractable;
    [SerializeField] public Transform currShip;
    [SerializeField] public Ship currShipScript;


    FirstPersonController FPSC;

    // Use this for initialization
    void Start () {
        FPSC = transform.GetComponent<FirstPersonController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer) {
            if (Input.GetKeyUp(KeyCode.E) && canInteract) {
                currInteractable.GetComponent<Interactable>().Interact(transform);
            }
        }
        if (isLocalPlayer && FPSC.piloting) {
            //throttle up
            if (Input.GetKey(KeyCode.W)) {
                currShipScript.shipCurrVelocity.x += 0.1f;
            }
            //throttle down
            if (Input.GetKey(KeyCode.S)) {
                currShipScript.shipCurrVelocity.x -= 0.1f;
            }
        }
    }
    
}

