using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SyncHands : NetworkBehaviour {

    public bool isLeft;


    private Animator anim;

    public enum GESTURE
    {
        IDLE,
        POINT,
        GRAB,
    }

    [SyncVar]
    public GESTURE gesture = GESTURE.IDLE;

    void Awake ()
    {
        anim = GetComponent<Animator>();
    }

    void Start () {
	    
	}
	
    private void AnimateHand()
    {
        switch (gesture)
        {
            case GESTURE.IDLE:
                anim.SetBool("Point", false);
                anim.SetBool("GripBall", false);
                anim.SetBool("Idle", true);
                break;
            case GESTURE.POINT:
                //anim.SetBool("GripBall", false);
                //anim.SetBool("Idle", false);
                anim.SetBool("Point", true);
                break;

            case GESTURE.GRAB:
                //anim.SetBool("Point", false);
                //anim.SetBool("Idle", false);
                anim.SetBool("GripBall", true);
                break;
            default:
                break;
        }
    }

  
	void LateUpdate () {


        AnimateHand();

    }
}
