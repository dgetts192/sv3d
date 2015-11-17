using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkSetup : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if(!isLocalPlayer){
			GetComponent<AudioSource>().enabled = false;
			transform.FindChild("Ethan").gameObject.SetActive(true);
			transform.FindChild("FirstPersonCharacter").GetComponent<AudioListener>().enabled = false;
			transform.FindChild("FirstPersonCharacter").GetComponent<Camera>().enabled = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
