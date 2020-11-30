using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class clickMe : MonoBehaviour
{
	
	[DllImport("__Internal")]
    private static extern void showEnigma(string str);
	
	public string objectName;
	public AudioSource audioData;
	
	private void OnMouseDown()
	{	
		//this.setActive = false;
		audioData.Play(0);
		Debug.Log(objectName);
		showEnigma(objectName);		
	}
}