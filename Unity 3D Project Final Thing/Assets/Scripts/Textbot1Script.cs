using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Textbot1Script : MonoBehaviour {

	public Text Textbot1;

	IEnumerator OnTriggerEnter(Collider other){

		Textbot1.text = ("Welcome to Space Escape"); 
		yield return new WaitForSeconds (3);
		Textbot1.text = ("Use the WASD Keys to Move");
		yield return new WaitForSeconds (3);
		Textbot1.text = ("Walk through the Door to Begin");
		yield return new WaitForSeconds (3);
		Textbot1.text = ("");
	
	}

	
}
