using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GhostVacuum : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent == null || transform.parent.tag != "VuforiaTrackerBody")
        {
            GameObject tracker = GameObject.FindGameObjectWithTag("VuforiaTrackerBody");
            if (tracker != null)
            {
                transform.parent = tracker.transform;
                transform.localPosition = Vector3.zero;
            }
        }

    }

}
