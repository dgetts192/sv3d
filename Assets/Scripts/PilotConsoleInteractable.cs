using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class PilotConsoleInteractable : Interactable {

    public override void Interact(Transform interactor) {
        interactor.GetComponent<FirstPersonController>().piloting = !interactor.GetComponent<FirstPersonController>().piloting;
        if (interactor.GetComponent<FirstPersonController>().piloting){
            interactor.GetComponent<CustomInput>().currShip = transform.root;
            interactor.GetComponent<CustomInput>().currShipScript = transform.root.GetComponent<Ship>();
        }
    }
    
}
