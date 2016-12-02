using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[RequireComponent(typeof(GrabHighlight), typeof(Rigidbody), typeof(Collider))]
public class ViveGrabbable : NetworkBehaviour
{

    [SyncVar]
    public bool highlightObject = false;

    private Rigidbody rigid;

    public void OnHover()
    {
        highlightObject = true;
    }

    public void OnHoverLeave()
    {
        highlightObject = false;
    }

    public virtual void OnGrab()
    {
        highlightObject = true;
    }

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }

    void Update()
    {


        if (highlightObject)
        {
            GetComponent<GrabHighlight>().DrawOutline();
        }
        else
        {
            GetComponent<GrabHighlight>().EraseOutline();
        }
    }
}
