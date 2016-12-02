using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class VacuumPadClientAuthority : NetworkBehaviour {


	// Use this for initialization
	void Start () {
        GetComponent<NetworkIdentity>().localPlayerAuthority = true;
        GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);
    }
	
	// Update is called once per frame
	void Update () {
        CmdGiveAuthority();
	}

    [Command]
    void CmdGiveAuthority()
    {
        GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);
    }

}
