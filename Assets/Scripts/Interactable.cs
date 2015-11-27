using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public abstract class Interactable : NetworkBehaviour {

    public abstract void Interact(Transform interactor);

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.transform.GetComponent<CustomInput>().canInteract = true;
            other.transform.GetComponent<CustomInput>().currInteractable = transform;
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            other.transform.GetComponent<CustomInput>().canInteract = false;
            other.transform.GetComponent<CustomInput>().currInteractable = null;
        }
    }
}

