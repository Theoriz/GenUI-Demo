using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCReceiverExample : MonoBehaviour
{
    public bool ShowDebug;

    private OSCMaster oscMaster;

	// Use this for initialization
	void Start ()
	{
	    oscMaster = FindObjectOfType<OSCMaster>();
	    oscMaster.messageAvailable += message =>
	    {
            if(ShowDebug)
	            Debug.Log("Message received : " + message.Address + " " + message.Data);
	    };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
