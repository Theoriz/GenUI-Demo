using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCReceiverExample : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	    OSCMaster.instance.messageAvailable += message =>
	    {
	        Debug.Log("Message received : " + message.Address + " " + message.Data);
	    };
	}
}
