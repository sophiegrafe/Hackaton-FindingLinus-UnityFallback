using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
	
	public GameObject target;

	private void PlayAgain()
	{	
		target.active = true;
		Debug.Log("Play Again!");
	}
}
