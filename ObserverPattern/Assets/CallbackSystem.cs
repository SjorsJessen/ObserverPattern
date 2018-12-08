using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackSystem : MonoBehaviour
{

	public delegate void OnMessageReceived();
	public event OnMessageReceived onComplete;
	
	// Use this for initialization
	void Start ()
	{
		onComplete += WriteMessage;
		onComplete();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void WriteMessage()
	{
		Debug.Log("WriteMessage() called");
	}
}
