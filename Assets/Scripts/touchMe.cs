using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class touchMe : MonoBehaviour
{
	
	[DllImport("__Internal")]
    private static extern void HelloString(string str);
	
	[DllImport("__Internal")]
    private static extern void showEnigma(string str);

	//public string myMsg = "Don't touch me!";
	public GameObject target;
	public AudioSource audioData;
	
	private void OnTriggerEnter(Collider other)
	{	
		if (other.CompareTag("Player"))
		{
			target.active = false;
			audioData.Play(0);
			showEnigma("You touched me!");
			Debug.Log("Touched!");
		}
	}
}
