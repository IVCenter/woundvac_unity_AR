using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class AutomaticClientConnect : NetworkManager {

    NetworkManager netMan;

	// Use this for initialization
	void Start () {
        netMan = NetworkManager.singleton;

        netMan.networkAddress = "137.110.119.201";
        netMan.networkPort = (int)7777;
        netMan.maxConnections = 4;

        netMan.StartClient();
        
	}
	
	// Update is called once per frame
	//void Update () {
	//
	//}
}
