using UnityEngine;
using System.Collections;

public class AutoConnect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Network.Connect("137.110.83.24");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
